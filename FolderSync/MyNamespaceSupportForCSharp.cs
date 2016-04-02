using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

// This file was created by the VB to C# converter (SharpDevelop 4.4.2.9749).
// It contains classes for supporting the VB "My" namespace in C#.
// If the VB application does not use the "My" namespace, or if you removed the usage
// after the conversion to C#, you can delete this file.

namespace FolderSync.My
{
	sealed partial class MyProject
	{
		[ThreadStatic] static MyApplication application;
		
		public static MyApplication Application {
			[DebuggerStepThrough]
			get {
				if (application == null)
					application = new MyApplication();
				return application;
			}
		}
		
		[ThreadStatic] static MyComputer computer;
		
		public static MyComputer Computer {
			[DebuggerStepThrough]
			get {
				if (computer == null)
					computer = new MyComputer();
				return computer;
			}
		}
		
		[ThreadStatic] static User user;
		
		public static User User {
			[DebuggerStepThrough]
			get {
				if (user == null)
					user = new User();
				return user;
			}
		}
		
		[ThreadStatic] static MyForms forms;
		
		public static MyForms Forms {
			[DebuggerStepThrough]
			get {
				if (forms == null)
					forms = new MyForms();
				return forms;
			}
		}
		
		internal sealed class MyForms
		{
			global::FolderSync.frm_news frm_news_instance;
			bool frm_news_isCreating;
			public global::FolderSync.frm_news frm_news {
				[DebuggerStepThrough] get { return GetForm(ref frm_news_instance, ref frm_news_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frm_news_instance, value); }
			}
			
			global::FolderSync.frm_splash frm_splash_instance;
			bool frm_splash_isCreating;
			public global::FolderSync.frm_splash frm_splash {
				[DebuggerStepThrough] get { return GetForm(ref frm_splash_instance, ref frm_splash_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frm_splash_instance, value); }
			}
			
			global::FolderSync.frm_options frm_options_instance;
			bool frm_options_isCreating;
			public global::FolderSync.frm_options frm_options {
				[DebuggerStepThrough] get { return GetForm(ref frm_options_instance, ref frm_options_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frm_options_instance, value); }
			}
			
			global::FolderSync.frm_trash frm_trash_instance;
			bool frm_trash_isCreating;
			public global::FolderSync.frm_trash frm_trash {
				[DebuggerStepThrough] get { return GetForm(ref frm_trash_instance, ref frm_trash_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frm_trash_instance, value); }
			}
			
			global::FolderSync.frm_main frm_main_instance;
			bool frm_main_isCreating;
			public global::FolderSync.frm_main frm_main {
				[DebuggerStepThrough] get { return GetForm(ref frm_main_instance, ref frm_main_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frm_main_instance, value); }
			}
			
			global::FolderSync.frm_fileList frm_fileList_instance;
			bool frm_fileList_isCreating;
			public global::FolderSync.frm_fileList frm_fileList {
				[DebuggerStepThrough] get { return GetForm(ref frm_fileList_instance, ref frm_fileList_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frm_fileList_instance, value); }
			}
			
			[DebuggerStepThrough]
			static T GetForm<T>(ref T instance, ref bool isCreating) where T : Form, new()
			{
				if (instance == null || instance.IsDisposed) {
					if (isCreating) {
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
					isCreating = true;
					try {
						instance = new T();
					} catch (System.Reflection.TargetInvocationException ex) {
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", new string[] { ex.InnerException.Message }), ex.InnerException);
					} finally {
						isCreating = false;
					}
				}
				return instance;
			}
			
			[DebuggerStepThrough]
			static void SetForm<T>(ref T instance, T value) where T : Form
			{
				if (instance != value) {
					if (value == null) {
						instance.Dispose();
						instance = null;
					} else {
						throw new ArgumentException("Property can only be set to null");
					}
				}
			}
		}
	}
	
	partial class MyApplication : WindowsFormsApplicationBase
	{
		[STAThread]
		public static void Main(string[] args)
		{
			Application.SetCompatibleTextRenderingDefault(UseCompatibleTextRendering);
			MyProject.Application.Run(args);
		}
	}
	
	partial class MyComputer : Computer
	{
	}
}
