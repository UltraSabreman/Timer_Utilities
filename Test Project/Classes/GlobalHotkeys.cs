using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

public struct HotKey {
	public ModKeys Modifier;
	public Keys KeyCode;
	public int ID;

	public HotKey(ModKeys m, Keys k, int ID = 0) {
		Modifier = m;
		KeyCode = k;
		this.ID = ID;
	}
}

public sealed class KeyboardHook : IDisposable {
	// Registers a hot key with Windows.
	[DllImport("user32.dll")]
	private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
	// Unregisters the hot key with Windows.
	[DllImport("user32.dll")]
	private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
	/// <summary>
	/// Represents the window that is used internally to get the messages.
	/// </summary>
	private class Window : NativeWindow, IDisposable {
		private static int WM_HOTKEY = 0x0312;

		public Window() {
			// create the handle for the window.
			this.CreateHandle(new CreateParams());
		}

		/// <summary>
		/// Overridden to get the notifications.
		/// </summary>
		/// <param name="m"></param>
		protected override void WndProc(ref Message m) {
			base.WndProc(ref m);

			// check if we got a hot key pressed.
			if (m.Msg == WM_HOTKEY) {
				// get the keys.
				Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
				ModKeys modifier = (ModKeys)((int)m.LParam & 0xFFFF);

				// invoke the event to notify the parent.
				if (KeyPressed != null)
					KeyPressed(this, new KeyPressedEventArgs(modifier, key));
			}
		}

		public event EventHandler<KeyPressedEventArgs> KeyPressed;

		#region IDisposable Members

		public void Dispose() {
			this.DestroyHandle();
		}

		#endregion
	}

	private Window _window = new Window();
	private int _currentId;
	private List<HotKey> keys = new List<HotKey>();


	public KeyboardHook() {
		// register the event of the inner native window.
		_window.KeyPressed += delegate(object sender, KeyPressedEventArgs args) {
			if (KeyPressed != null)
				KeyPressed(this, args);
		};
	}

	/// <summary>
	/// Registers a hot key in the system.
	/// </summary>
	/// <param name="modifier">The modifiers that are associated with the hot key.</param>
	/// <param name="key">The key itself that is associated with the hot key.</param>
	public void RegisterHotKey(ModKeys modifier, Keys key) {
		// increment the counter.
		_currentId = _currentId + 1;

		keys.Add(new HotKey(modifier, key, _currentId));
		HotKey temp = keys.Last();

		// register the hot key.
		if (!RegisterHotKey(_window.Handle, temp.ID, (uint)temp.Modifier, (uint)temp.KeyCode))
			throw new InvalidOperationException("Couldn’t register the hot key.");
	}

	/// <summary>
	/// Registers a hot key in the system.
	/// </summary>
	/// <param name="hotkey">A HotKey Struct</param>
	public void RegisterHotKey(HotKey hotkey) {
		_currentId = _currentId + 1;

		hotkey.ID = _currentId;
		keys.Add(hotkey);

		// register the hot key.
		if (!RegisterHotKey(_window.Handle, hotkey.ID, (uint)hotkey.Modifier, (uint)hotkey.KeyCode))
			throw new InvalidOperationException("Couldn’t register the hot key.");
	}

	/// <summary>
	/// Unregisters a hot key in the system.
	/// </summary>
	/// <param name="modifier">The modifiers that are associated with the hot key.</param>
	/// <param name="key">The key itself that is associated with the hot key.</param>
	public void UnregisterHotKey(ModKeys modifier, Keys key) {
		foreach (HotKey k in keys) {
			if (k.Modifier == modifier && k.KeyCode == key) {
				UnregisterHotKey(_window.Handle, k.ID);
				keys.Remove(k);
				return;
			}
		}
		throw new InvalidOperationException("Couldn’t unregister the hot key.");
	}

	/// <summary>
	/// Unregisters a hot key in the system.
	/// </summary>
	/// <param name="hotkey">A HotKey Struct</param>
	public void UnregisterHotKey(HotKey hotkey) {
		if (keys.Contains(hotkey)) {
			UnregisterHotKey(_window.Handle, hotkey.ID);
			keys.Remove(hotkey);
		} else
			throw new InvalidOperationException("Couldn’t unregister the hot key.");
	}

	/// <summary>
	/// A hot key has been pressed.
	/// </summary>
	public event EventHandler<KeyPressedEventArgs> KeyPressed;

	#region IDisposable Members

	public void Dispose() {
		// unregister all the registered hot keys.
		foreach (HotKey k in keys)
			UnregisterHotKey(_window.Handle, k.ID);

		// dispose the inner native window.
		_window.Dispose();
	}

	#endregion
}

/// <summary>
/// Event Args for the event that is fired after the hot key has been pressed.
/// </summary>
public class KeyPressedEventArgs : EventArgs {
	private ModKeys _modifier;
	private Keys _key;

	internal KeyPressedEventArgs(ModKeys modifier, Keys key) {
		_modifier = modifier;
		_key = key;
	}

	public ModKeys Modifier {
		get { return _modifier; }
	}

	public Keys Key {
		get { return _key; }
	}
}

/// <summary>
/// The enumeration of possible modifiers.
/// </summary>
[Flags]
public enum ModKeys : uint {
	None = 0,
	Alt = 1,
	Control = 2,
	Shift = 4,
	Win = 8
}
