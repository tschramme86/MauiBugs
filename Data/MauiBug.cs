using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBugs.Data
{
    enum EnvironmentStatus
    {
        NotTested,
        Affected,
        NotAffected
    }

    class MauiBug
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; } = "-";

        public EnvironmentStatus StatusAndroid { get; set; } = EnvironmentStatus.NotTested;

        public EnvironmentStatus StatusIos { get; set; } = EnvironmentStatus.NotTested;

        public EnvironmentStatus StatusWindows { get; set; } = EnvironmentStatus.NotTested;

        public string LastMauiTestVersion { get; set; }

        public bool IsActive { get; set; }

        public string MauiFixVersion { get; set; }

        public Type BugDemoPage { get; set; }

        public string GitHubIssues { get; set; }
    }
}
