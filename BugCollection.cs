using MauiBugs.Bugs.Bug001_ButtonTextWrap;
using MauiBugs.Bugs.Bug002_MultiLineLayout;
using MauiBugs.Bugs.Bug003_TapGestureRecognizer;
using MauiBugs.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBugs
{
    class BugCollection
    {
        public static List<MauiBug> Bugs = new() {
            new MauiBug { 
                Id = "b001", Title = "Text Wrap in Button", 
                IsActive = true, LastMauiTestVersion = "7.0.49",
                StatusAndroid = EnvironmentStatus.NotAffected,
                StatusWindows = EnvironmentStatus.Affected,
                BugDemoPage = typeof(Bug001ButtonTextWrap)
            },
            new MauiBug {
                Id = "b002", Title = "Wrong Label Height when MultiLine",
                IsActive = true, LastMauiTestVersion = "7.0.49",
                StatusAndroid = EnvironmentStatus.Affected,
                StatusWindows = EnvironmentStatus.Affected,
                BugDemoPage = typeof(Bug002MultiLineLayout)
            },
            new MauiBug {
                Id = "b003", Title = "TapGestureRecognizer not firing",
                IsActive = true, LastMauiTestVersion = "7.0.49",
                StatusAndroid = EnvironmentStatus.Affected,
                StatusWindows = EnvironmentStatus.Affected,
                BugDemoPage = typeof(Bug003TapGestureRecognizer)
            },
        };
    }
}
