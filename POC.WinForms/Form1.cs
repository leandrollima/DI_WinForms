using POC.EFCore.Context;
using POC.WinForms.Extensions;

namespace POC.WinForms
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext appDbContext;

        public Form1()
        {

        }
        public Form1(AppDbContext appDbContext)
        {
            InitializeComponent();
            this.appDbContext = appDbContext;
            this.Shown += Form1_Shown;
        }

        private void Form1_Shown(object? sender, EventArgs e)
        {
            printCategories();
        }

        private void printCategories()
        {
            var categories = appDbContext.Categories.ToList();
            foreach (var categorie in categories)
            {
                this.Invoke(() => { richTextBox1.AppendLine(categorie.ToString()); });
                
            }
        }
    }
}