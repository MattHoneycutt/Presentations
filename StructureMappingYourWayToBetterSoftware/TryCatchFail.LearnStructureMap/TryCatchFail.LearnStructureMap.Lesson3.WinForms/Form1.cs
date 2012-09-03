using System;
using System.Windows.Forms;
using StructureMap;
using TryCatchFail.LearnStructureMap.Lesson3.WinForms.MVP;
using TryCatchFail.LearnStructureMap.Lesson3.WinForms.Services;

namespace TryCatchFail.LearnStructureMap.Lesson3.WinForms
{
	public partial class Form1 : Form, IWelcomeForm
	{
		private readonly WelcomeFormPresenter _presenter;

		public Form1()
		{
			InitializeComponent();
			_presenter = ObjectFactory.With<IWelcomeForm>(this).GetInstance<WelcomeFormPresenter>();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			_presenter.OnLoad();
		}

		public string WelcomeMessage
		{
			get { return lblWelcomeMessage.Text; }
			set { lblWelcomeMessage.Text = value;  }
		}
	}
}
