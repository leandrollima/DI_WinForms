namespace POC.WinForms.Extensions
{
    public static class RichTextBoxExtensions
    {
        public static void AppendLine(this RichTextBox textBox, string text)
        {
            textBox.AppendText($"{text}{Environment.NewLine}");   
        }
    }
}
