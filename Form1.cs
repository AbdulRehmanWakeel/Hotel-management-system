using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_room_booking_and_billing_system
{
    public partial class Form1 : MaterialForm
    {
        public Form1(ColorScheme colorScheme)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            object value = materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.Dark;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        public object Primary { get; private set; }
        public object Accent { get; private set; }
        public object MaterialSkinManager { get; private set; }

        public override bool Equals(object obj)
        {
            return obj is Form1 form &&
                   EqualityComparer<object>.Default.Equals(Primary, form.Primary) &&
                   EqualityComparer<object>.Default.Equals(Accent, form.Accent) &&
                   EqualityComparer<object>.Default.Equals(MaterialSkinManager, form.MaterialSkinManager) &&
                   EqualityComparer<IContainer>.Default.Equals(components, form.components);
        }
    }

    internal class TextShade
    {
    }
}
