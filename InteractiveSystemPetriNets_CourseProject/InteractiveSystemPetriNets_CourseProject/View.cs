using System;
using System.Windows.Forms;

namespace InteractiveSystemPetriNets_CourseProject
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler okButtonPressing = null;
        public event EventHandler saveDialogueMoveButtonPressing = null;
        public event EventHandler openDialogueMenuItemPressing = null;
        public event EventHandler closeMenuItemPressing = null;


        private void OnOkButtonPressing(object sender, EventArgs e)
        {
            okButtonPressing(sender, e);
        }

        private void OnSaveDialogueMoveButtonPressing(object sender, EventArgs e)
        {
            saveDialogueMoveButtonPressing(sender, e);
        }

        private void OnOpenDialogueMenuItemPressing(object sender, EventArgs e)
        {
            openDialogueMenuItemPressing(sender, e);
        }

        private void OnCloseMenuItemPressing(object sender, EventArgs e)
        {
            closeMenuItemPressing(sender, e);
        }

    }
}
