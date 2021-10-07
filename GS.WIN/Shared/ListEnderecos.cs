using System;
using GS.API.Data;
using System.Windows.Forms;

namespace GS.WIN.Shared
{
    public partial class ListEnderecos : Form
    {
        private readonly Postgre_Context _context;
               
        public ListEnderecos(Postgre_Context context)
        {
            InitializeComponent();
            _context = context;
        }

        private void ListEnderecos_Load(object sender, EventArgs e)
        {

        }
    }
}
