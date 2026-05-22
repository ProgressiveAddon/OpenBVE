#if NO_WINFORMS
using System;

namespace System.Windows.Forms
{
    public interface IWin32Window
    {
        IntPtr Handle { get; }
    }

    public class ComboBox
    {
        public object DataSource { get; set; }
        public string DisplayMember { get; set; }
        public string ValueMember { get; set; }
        public int SelectedIndex { get; set; }
        public object SelectedItem { get; set; }
        public ObjectCollection Items { get; } = new ObjectCollection();

        public class ObjectCollection : System.Collections.ObjectModel.Collection<object>
        {
        }
    }

    public class BindingSource
    {
        public BindingSource(object dataSource, string dataMember) { }
    }

    public static class Application
    {
        public static string StartupPath => AppContext.BaseDirectory;
    }

    public enum MessageBoxButtons
    {
        OK
    }

    public enum MessageBoxIcon
    {
        Warning,
        Hand
    }

    public static class MessageBox
    {
        public static void Show(string text) { }
        public static void Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon) { }
    }
}
#endif
