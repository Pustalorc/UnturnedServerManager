using Rocket.API.Serialisation;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATORTTeam.UnturnedServerManager.GUI
{
    public partial class RocketPermissions : Form
    {
        private bool Reloaded = false;
        private string SelectedGroup = "";
        private string SelectedMember = "";
        private string SelectedPermission = "";

        public RocketPermissions(string Directory)
        {
            InitializeComponent();
            
            Memory.Permissions.Load(Directory);
            LoadPermissions();
        }

        // Custom Methods
        private void LoadPermissions()
        {
            Reloaded = true;

            Groups.Items.Clear();
            ParentGroup.Items.Clear();
            foreach (var g in Memory.Permissions.Perms.Groups)
            {
                Groups.Items.Add(g.Id);
                ParentGroup.Items.Add(g.Id);
            }

            if (Groups.Items.Count == 0)
            {
                ToggleElements(false);
                UnloadDetails();
            }
            else
            {
                Groups.SelectedIndex = 0;
                SelectedGroup = (string)Groups.SelectedItem;
                ToggleElements(true);
                LoadDetails();
            }

            Reloaded = false;
        }
        private void ToggleElements(bool Status)
        {
            DisplayName.Enabled = Status;
            Prefix.Enabled = Status;
            Suffix.Enabled = Status;
            ChatColor.Enabled = Status;
            ParentGroup.Enabled = Status;
            Priority.Enabled = Status;
            IsDefault.Enabled = Status;
            Remove.Enabled = Status;
            Clone.Enabled = Status;
            Permissions.Enabled = Status;
            Cooldown.Enabled = false;
            AddPerm.Enabled = Status;
            RemPerm.Enabled = false;
            Members.Enabled = Status;
            RemMem.Enabled = false;
            AddMem.Enabled = Status;
        }
        private void LoadDetails()
        {
            Reloaded = true;

            UnloadDetails();

            var group = Memory.Permissions.Perms.Groups.Find(k => string.Equals(k.Id, SelectedGroup, StringComparison.InvariantCultureIgnoreCase));
            if (group != null)
            {
                DisplayName.Text = group.DisplayName;
                Prefix.Text = group.Prefix;
                Suffix.Text = group.Suffix;
                ChatColor.Text = group.Color;
                ParentGroup.Text = group.ParentGroup;
                Priority.Value = group.Priority;
                IsDefault.Checked = string.Equals(Memory.Permissions.Perms.DefaultGroup, group.Id, StringComparison.InvariantCultureIgnoreCase);
                
                foreach (var p in group.Permissions)
                    Permissions.Items.Add(p.Name);
                if (Permissions.Items.Count > 0)
                {
                    Permissions.SelectedIndex = 0;
                    SelectedPermission = (string)Permissions.SelectedItem;
                    var p = group.Permissions.Find(k => k.Name == SelectedPermission);
                    Cooldown.Value = p.Cooldown;

                    RemPerm.Enabled = true;
                    Cooldown.Enabled = true;
                }

                foreach (var m in group.Members)
                    Members.Items.Add(m);
                if (Members.Items.Count > 0)
                {
                    Members.SelectedIndex = 0;
                    SelectedMember = (string)Members.SelectedItem;
                    RemMem.Enabled = true;
                }
            }

            Reloaded = false;
        }
        private void UnloadDetails()
        {
            DisplayName.Text = "";
            Prefix.Text = "";
            Suffix.Text = "";
            ChatColor.Text = "";
            ParentGroup.Text = "";
            Priority.Value = Priority.Minimum;
            IsDefault.Checked = false;

            Permissions.Items.Clear();
            RemPerm.Enabled = false;
            Cooldown.Value = Cooldown.Minimum;
            Cooldown.Enabled = false;

            Members.Items.Clear();
            RemMem.Enabled = false;
        }

        // Control Events
        private void Remove_Click(object sender, EventArgs e)
        {
            var group = Memory.Permissions.Perms.Groups.Find(k => k.Id == SelectedGroup);
            if (group != null)
                Memory.Permissions.Perms.Groups.Remove(group);

            LoadPermissions();
        }
        private void RemMem_Click(object sender, EventArgs e)
        {
            var group = Memory.Permissions.Perms.Groups.Find(k => k.Id == SelectedGroup);
            if (group != null)
            {
                var member = group.Members.Find(k => k == SelectedMember);
                if (!string.IsNullOrEmpty(member))
                    group.Members.Remove(member);

                LoadDetails();
            }
            else
                LoadPermissions();
        }
        private void RemPerm_Click(object sender, EventArgs e)
        {
            var group = Memory.Permissions.Perms.Groups.Find(k => k.Id == SelectedGroup);
            if (group != null)
            {
                var permission = group.Permissions.Find(k => k.Name == SelectedPermission);
                if (permission != null)
                    group.Permissions.Remove(permission);

                LoadDetails();
            }
            else
                LoadPermissions();
        }
        private void Prefix_TextChanged(object sender, EventArgs e)
        {
            if (!Reloaded)
            {
                var group = Memory.Permissions.Perms.Groups.Find(k => k.Id == SelectedGroup);
                if (group != null)
                    group.Prefix = Prefix.Text;
                else
                    LoadPermissions();
            }
        }
        private void Suffix_TextChanged(object sender, EventArgs e)
        {
            if (!Reloaded)
            {
                var group = Memory.Permissions.Perms.Groups.Find(k => k.Id == SelectedGroup);
                if (group != null)
                    group.Suffix = Suffix.Text;
                else
                    LoadPermissions();
            }
        }
        private void Priority_ValueChanged(object sender, EventArgs e)
        {
            if (!Reloaded)
            {
                var group = Memory.Permissions.Perms.Groups.Find(k => k.Id == SelectedGroup);
                if (group != null)
                    group.Priority = (short)Priority.Value;
                else
                    LoadPermissions();
            }
        }
        private void ChatColor_TextChanged(object sender, EventArgs e)
        {
            if (!Reloaded)
            {
                var group = Memory.Permissions.Perms.Groups.Find(k => k.Id == SelectedGroup);
                if (group != null)
                    group.Color = ChatColor.Text;
                else
                    LoadPermissions();
            }
        }
        private void DisplayName_TextChanged(object sender, EventArgs e)
        {
            if (!Reloaded)
            {
                var group = Memory.Permissions.Perms.Groups.Find(k => k.Id == SelectedGroup);
                if (group != null)
                    group.DisplayName = DisplayName.Text;
                else
                    LoadPermissions();
            }
        }
        private void ParentGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Reloaded)
            {
                var group = Memory.Permissions.Perms.Groups.Find(k => k.Id == SelectedGroup);
                if (group != null)
                    group.ParentGroup = ParentGroup.Text;
                else
                    LoadPermissions();
            }
        }
        private void Cooldown_ValueChanged(object sender, EventArgs e)
        {
            if (!Reloaded)
            {
                var group = Memory.Permissions.Perms.Groups.Find(k => k.Id == SelectedGroup);
                if (group != null)
                {
                    var permission = group.Permissions.Find(k => k.Name == SelectedPermission);
                    if (permission != null)
                        permission.Cooldown = (uint)Cooldown.Value;
                    else
                        LoadDetails();
                }
                else
                    LoadPermissions();
            }
        }
        private void Permissions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Reloaded)
            {
                var group = Memory.Permissions.Perms.Groups.Find(k => k.Id == SelectedGroup);
                if (group != null)
                {
                    SelectedPermission = (string)Permissions.SelectedItem;
                    var perm = group.Permissions.Find(k => string.Equals(k.Name, SelectedPermission, StringComparison.InvariantCultureIgnoreCase));
                    if (perm == null)
                        LoadDetails();
                    else
                        Cooldown.Value = perm.Cooldown;
                }
                else
                    LoadPermissions();
            }
        }
        private void Groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Reloaded)
            {
                SelectedGroup = (string)Groups.SelectedItem;
                LoadDetails();
            }
        }
        private void Members_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Reloaded)
            {
                var group = Memory.Permissions.Perms.Groups.Find(k => k.Id == SelectedGroup);
                if (group != null)
                {
                    SelectedMember = (string)Members.SelectedItem;
                    var member = group.Members.Find(k => string.Equals(k, SelectedMember, StringComparison.InvariantCultureIgnoreCase));
                    if (member == null)
                        LoadDetails();
                }
                else
                    LoadPermissions();
            }
        }
        private void IsDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (!Reloaded)
            {
                var group = Memory.Permissions.Perms.Groups.Find(k => k.Id == SelectedGroup);
                if (group != null)
                    Memory.Permissions.Perms.DefaultGroup = group.Id;
                else
                    LoadPermissions();
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            Hide();

            var f = new AddOrCloneGroup();
            f.ShowDialog();
            var id = f.ID;
            if (!string.IsNullOrEmpty(id))
            {
                if (Memory.Permissions.Perms.Groups.Exists(k => string.Equals(k.Id, id, StringComparison.InvariantCultureIgnoreCase)))
                    return;
                else
                    Memory.Permissions.Perms.Groups.Add(new RocketPermissionsGroup(id, id, Memory.Permissions.Perms.DefaultGroup, new List<string>(), new List<Permission>(), "White", 100) { Prefix = "", Suffix = "" });
            }

            Show();
            LoadPermissions();
        }
        private void Clone_Click(object sender, EventArgs e)
        {
            var group = Memory.Permissions.Perms.Groups.Find(k => k.Id == SelectedGroup);
            if (group != null)
            {
                Hide();

                var f = new AddOrCloneGroup();
                f.ShowDialog();
                var id = f.ID;
                if (!string.IsNullOrEmpty(id))
                {
                    if (Memory.Permissions.Perms.Groups.Exists(k => string.Equals(k.Id, id, StringComparison.InvariantCultureIgnoreCase)))
                        return;
                    else
                        Memory.Permissions.Perms.Groups.Add(new RocketPermissionsGroup(id, id, group.ParentGroup, group.Members, group.Permissions, group.Color, group.Priority) { Prefix = group.Prefix, Suffix = group.Suffix });
                }

                Show();
                LoadPermissions();
            }
        }
        private void AddPerm_Click(object sender, EventArgs e)
        {
            var group = Memory.Permissions.Perms.Groups.Find(k => k.Id == SelectedGroup);
            if (group != null)
            {
                Hide();

                var f = new AddPermission();
                f.ShowDialog();
                var perm = f.Permission;
                var cooldown = f.Cooldown;
                if (!string.IsNullOrEmpty(perm))
                {
                    if (group.Permissions.Exists(k => string.Equals(k.Name, perm, StringComparison.InvariantCultureIgnoreCase)))
                        return;
                    else
                        group.Permissions.Add(new Permission(perm, cooldown));
                }

                Show();
                LoadDetails();
            }
            else LoadPermissions();
        }
        private void AddMem_Click(object sender, EventArgs e)
        {
            var group = Memory.Permissions.Perms.Groups.Find(k => k.Id == SelectedGroup);
            if (group != null)
            {
                Hide();

                var f = new AddMember();
                f.ShowDialog();
                var id = f.ID;
                if (id >= 76561197960265728)
                {
                    if (group.Members.Exists(k => string.Equals(k, id.ToString(), StringComparison.InvariantCultureIgnoreCase)))
                        return;
                    else
                        group.Members.Add(id.ToString());
                }

                Show();
                LoadDetails();
            }
            else LoadPermissions();
        }
        private void RocketPermissions_FormClosing(object sender, FormClosingEventArgs e) => Memory.Permissions.Unload();
        private void SExit_Click(object sender, EventArgs e) => Close();
    }
}
