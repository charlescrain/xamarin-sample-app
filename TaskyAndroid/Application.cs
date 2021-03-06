﻿using System;
using System.IO;
using SQLite;
using Android.App;
using Tasky.PortableLibrary;
using TaskyPortableLibrary;

namespace TaskyAndroid
{
	[Application]
	public class TaskyApp : Application {
		public static TaskyApp Current { get; private set; }

		public TodoItemManager TodoManager { get; set; }
        public TodoContractManager TodoContractMngr { get; set; }
		SQLiteConnection conn;

		public TaskyApp(IntPtr handle, global::Android.Runtime.JniHandleOwnership transfer)
			: base(handle, transfer) {
			Current = this;
		}

		public override void OnCreate()
		{
			base.OnCreate();

            TodoContractMngr = new TodoContractManager("http://40.118.255.235:8000",
                "http://40.118.255.235/eth/v1.2");
        }
	}
}

