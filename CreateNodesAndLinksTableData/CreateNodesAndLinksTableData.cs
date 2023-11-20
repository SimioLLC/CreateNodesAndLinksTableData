using SimioAPI;
using SimioAPI.Extensions;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CreateNodesAndLinksTableData
{
    internal class CreateNodesAndLinksTableDataTables : IDesignAddIn, IDesignAddInGuiDetails
    {
        #region IDesignAddIn Members

        /// <summary>
        /// Property returning the name of the add-in. This name may contain any characters and is used as the display name for the add-in in the UI.
        /// </summary>
        public string Name
        {
            get { return "Create Tables and Lists"; }
        }

        /// <summary>
        /// Property returning a short description of what the add-in does.
        /// </summary>
        public string Description
        {
            get { return "Create Tables and Lists."; }
        }

        /// <summary>
        /// Property returning an icon to display for the add-in in the UI.
        /// </summary>
        public System.Drawing.Image Icon
        {
            get { return Properties.Resources.CreateTables; }
        }

        /// <summary>
        /// Method called when the add-in is run.
        /// </summary>
        public void Execute(IDesignContext context)
        {
            // This example code places some new objects from the Standard Library into the active model of the project.
            if (context.ActiveModel != null)
            {
                // Add Node Locations List
                var nodeLocationsList = context.ActiveModel.NamedLists["CreateNodesAndLinksNodeLocations"];
                if (nodeLocationsList != null)
                {
                    MessageBox.Show("CreateNodesAndLinksNodeLocations List Already Exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    nodeLocationsList = context.ActiveModel.NamedLists.AddStringList("CreateNodesAndLinksNodeLocations");
                    var firstRow = nodeLocationsList.Rows.Create();
                    firstRow.Properties[0].Value = "BothBelowObject";
                    var secondRow = nodeLocationsList.Rows.Create();
                    secondRow.Properties[0].Value = "InputLeftOutputRight";
                    var thirdRow = nodeLocationsList.Rows.Create();
                    thirdRow.Properties[0].Value = "InputLeft";
                    var forthRow = nodeLocationsList.Rows.Create();
                    forthRow.Properties[0].Value = "OutputRight";
                    MessageBox.Show("CreateNodesAndLinksNodeLocations List Created");
                }

                // Add Direction List
                var directionList = context.ActiveModel.NamedLists["CreateNodesAndLinksDirection"];
                if (directionList != null)
                {
                    MessageBox.Show("CreateNodesAndLinksDirection List Already Exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    directionList = context.ActiveModel.NamedLists.AddStringList("CreateNodesAndLinksDirection");

                    var firstRow = directionList.Rows.Create();
                    firstRow.Properties[0].Value = "LeftToRight";
                    var secondRow = directionList.Rows.Create();
                    secondRow.Properties[0].Value = "RightToLeft";
                    var thirdRow = directionList.Rows.Create();
                    thirdRow.Properties[0].Value = "TopToBottom";
                    var fourthRow = directionList.Rows.Create();
                    fourthRow.Properties[0].Value = "BottomToTop";
                    MessageBox.Show("CreateNodesAndLinksDirection List Created");
                }

                // Add CreateNodesAndLinks Table
                var tbl = context.ActiveModel.Tables["CreateNodesAndLinks"];
                if (tbl != null)
                {
                    MessageBox.Show("CreateNodesAndLinks Table Already Exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    tbl = context.ActiveModel.Tables.Create("CreateNodesAndLinks");
                    var s = tbl.Columns.AddStringColumn("ObjectType", "Rack");
                    s = tbl.Columns.AddStringColumn("ObjectPropertyName", "");
                    s = tbl.Columns.AddStringColumn("ObjectPropertyValue", "");
                    s = tbl.Columns.AddStringColumn("NodeType", "RackNode");
                    s = tbl.Columns.AddStringColumn("LinkType", "RackPath");
                    var r = tbl.Columns.AddRealColumn("NodeOffset", 1.5);
                    (r as IUnitizedTableColumn).UnitType = SimioUnitType.Length;
                    r = tbl.Columns.AddRealColumn("UseExistingNodeOffset", 0.5);
                    (r as IUnitizedTableColumn).UnitType = SimioUnitType.Length;
                    var l = tbl.Columns.AddListReferenceColumn("NodeLocations");
                    l.ListName = "CreateNodesAndLinksNodeLocations";
                    l.DefaultString = "BothBelowObject";
                    l = tbl.Columns.AddListReferenceColumn("Direction");
                    l.ListName = "CreateNodesAndLinksDirection";
                    l.DefaultString = "LeftToRight";
                    var row = tbl.Rows.Create();
                    MessageBox.Show("CreateNodesAndLinksTableData Table Created");
                }

                // Add AddNodesAndLinksToTables Table
                tbl = context.ActiveModel.Tables["AddNodesLinksVerticesToTables"];
                if (tbl != null)
                {
                    MessageBox.Show("AddNodesLinksVerticesToTables Table Already Exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    tbl = context.ActiveModel.Tables.Create("AddNodesLinksVerticesToTables");
                    var s = tbl.Columns.AddStringColumn("LinkType", "RackPath");
                    s = tbl.Columns.AddStringColumn("LinkPropertyName", "");
                    s = tbl.Columns.AddStringColumn("LinkPropertyValue", "");
                    var t = tbl.Columns.AddTableReferenceColumn("NodesTable");
                    t.DefaultString = "Nodes";
                    s = tbl.Columns.AddStringColumn("NodeColumnName", "Node");
                    s = tbl.Columns.AddStringColumn("NodeTypeColumnName", "Type");
                    s = tbl.Columns.AddStringColumn("NodeXColumnName", "X");
                    s = tbl.Columns.AddStringColumn("NodeYColumnName", "Y");
                    s = tbl.Columns.AddStringColumn("NodeZColumnName", "Z");
                    t = tbl.Columns.AddTableReferenceColumn("LinksTable");
                    t.DefaultString = "Links";
                    s = tbl.Columns.AddStringColumn("LinkColumnName", "Link");
                    s = tbl.Columns.AddStringColumn("LinkTypeColumnName", "Type");
                    s = tbl.Columns.AddStringColumn("StartingNodeColumnName", "StartingNode");
                    s = tbl.Columns.AddStringColumn("EndingNodeColumnName", "EndingNode");

                    t = tbl.Columns.AddTableReferenceColumn("VerticesTable");
                    t.DefaultString = "Vertices";
                    s = tbl.Columns.AddStringColumn("VertexLinkColumnName", "Link");
                    s = tbl.Columns.AddStringColumn("VertexXColumnName", "X");
                    s = tbl.Columns.AddStringColumn("VertexYColumnName", "Y");
                    s = tbl.Columns.AddStringColumn("VertexZColumnName", "Z");
                    s = tbl.Columns.AddBooleanColumn("TablesUseAutoCreate", true);
                    var row = tbl.Rows.Create();
                    MessageBox.Show("AddNodesAndLinksToTables Table Created");
                }

                // Add CreateNodesAndLinks Table
                tbl = context.ActiveModel.Tables["MoveNodesToObjectEdges"];
                if (tbl != null)
                {
                    MessageBox.Show("MoveNodesToObjectEdges Table Already Exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    tbl = context.ActiveModel.Tables.Create("MoveNodesToObjectEdges");
                    var s = tbl.Columns.AddStringColumn("ObjectType", "Rack");
                    var row = tbl.Rows.Create();
                    MessageBox.Show("MoveNodesToObjectEdges Table Created");
                }
            }
        }

        #endregion

        #region IDesignAddInGuiDetails Members

        public string CategoryName
        {
            get { return null; }
        }

        public string TabName
        {
            get { return "Add-Ins"; }
        }

        public string GroupName
        {
            get { return "Create Nodes And Links Table Data"; }
        }

        #endregion
    }

    internal class CreateNodesAndLinks : IDesignAddIn, IDesignAddInGuiDetails
    {
        #region IDesignAddIn Members

        /// <summary>
        /// Property returning the name of the add-in. This name may contain any characters and is used as the display name for the add-in in the UI.
        /// </summary>
        public string Name
        {
            get { return "Create Nodes And Links"; }
        }

        /// <summary>
        /// Property returning a short description of what the add-in does.
        /// </summary>
        public string Description
        {
            get { return "Create Nodes And Links."; }
        }

        /// <summary>
        /// Property returning an icon to display for the add-in in the UI.
        /// </summary>
        public System.Drawing.Image Icon
        {
            get { return Properties.Resources.CreateNodesAndLinks; }
        }

        /// <summary>
        /// Method called when the add-in is run.
        /// </summary>
        public void Execute(IDesignContext context)
        {
            // This example code places some new objects from the Standard Library into the active model of the project.
            if (context.ActiveModel != null)
            {
                var tbl = context.ActiveModel.Tables["CreateNodesAndLinks"];
                if (tbl == null)
                {
                    MessageBox.Show("CreateNodesAndLinks Table Does Not Exists.  Please create table before running this add-in.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (tbl.Rows.Count == 0)
                {
                    tbl.Rows.Create();
                }
                if (tbl.Rows.Count > 1)
                {
                    MessageBox.Show("CreateNodesAndLinks Table Contains More Than One Row.   Only the first row will be used.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }                        
                    
                var f = new CreateNodesAndLinksForm();
                var row = tbl.Rows[0];
                f.NodeOffset.Text = row.Properties["NodeOffset"].Value;
                f.UseExistingNodeOffset.Text = row.Properties["UseExistingNodeOffset"].Value;
                f.ObjectType.Text = row.Properties["ObjectType"].Value;
                f.ObjectPropertyName.Text = row.Properties["ObjectPropertyName"].Value;
                f.ObjectPropertyValue.Text = row.Properties["ObjectPropertyValue"].Value;
                f.NodeType.Text = row.Properties["NodeType"].Value;
                f.LinkType.Text = row.Properties["LinkType"].Value;
                f.NodeLocations.Text = row.Properties["NodeLocations"].Value;
                f.Direction.Text = row.Properties["Direction"].Value;
                f.ShowDialog();

                if (f.OkButtonSelected == true)
                {
                    context.ActiveModel.BulkUpdate(model =>
                    {                        
                        var filterListOfObjectsByType = context.ActiveModel.Facility.IntelligentObjects.Where(r => r.TypeName == f.ObjectType.Text).ToList();

                        if (filterListOfObjectsByType.Count == 0)
                        {
                            MessageBox.Show("No Objects For Type Found", "No Objects For Type Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        var filterListOfObjects = new List<IIntelligentObject>();
                        
                        // If properyt defined
                        if (f.ObjectPropertyName.Text.Length > 0)
                        {
                            IIntelligentObject intellObj = filterListOfObjectsByType[0];
                            var prop = intellObj.Properties[f.ObjectPropertyName.Text];
                            if (prop == null)
                            {
                                MessageBox.Show("Property Name Not Found On Object", "Property Name Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            if (f.ObjectPropertyValue.Text.Length == 0)
                            {
                                MessageBox.Show("Property Value Not Provided", "Property Value Not Provided", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            filterListOfObjects = filterListOfObjectsByType.Where(r => r.Properties[f.ObjectPropertyName.Text].Value == f.ObjectPropertyValue.Text).ToList();
                        }
                        else
                        {
                            filterListOfObjects = filterListOfObjectsByType.ToList();

                        }
                        var sortedListOfObjects = new List<IIntelligentObject>();
                        if (f.Direction.Text == "LeftToRight") sortedListOfObjects = filterListOfObjects.OrderBy(z => z.Location.Z).ThenBy(y => y.Location.Y).ThenBy(x => x.Location.X).ToList();
                        else if (f.Direction.Text == "RightToLeft") sortedListOfObjects = filterListOfObjects.OrderBy(z => z.Location.Z).ThenBy(y => y.Location.Y).ThenBy(x => (x.Location.X * -1)).ToList();
                        else if (f.Direction.Text == "BottomToTop") sortedListOfObjects = filterListOfObjects.OrderBy(z => (z.Location.Z * -1)).ThenBy(y => y.Location.Y).ThenBy(x => x.Location.X).ToList();
                        else sortedListOfObjects = filterListOfObjects.OrderBy(x => x.Location.X).ThenBy(y => y.Location.Y).ThenBy(z => z.Location.Z).ToList();

                        IIntelligentObject prevNode0 = null;
                        IIntelligentObject prevNode1 = null;
                        IIntelligentObject node = null;
                        double useExistingNodeOffset = Convert.ToDouble(f.UseExistingNodeOffset.Text);
                        double nodeOffet = Convert.ToDouble(f.NodeOffset.Text);

                        foreach (IIntelligentObject intellObj in sortedListOfObjects)
                        {
                            int loopCount = 1;
                            bool InputLeftOuputRight = false;
                            if (f.NodeLocations.Text == "InputLeftOutputRight" || f.NodeLocations.Text == "InputLeft" || f.NodeLocations.Text == "OutputRight")
                            {
                                InputLeftOuputRight = true;
                                if (f.NodeLocations.Text == "InputLeftOutputRight" || f.NodeLocations.Text == "OutputRight")
                                {
                                    loopCount++;
                                }
                            }

                            // InputLeftOuputRight == False...Only one loop...InputLeftOuputRight == True...First loop for input and secons loop for output
                            for (int currentLoop = 0; currentLoop < loopCount; currentLoop++)
                            {
                                // if not first look or node locations not equal OutputRight
                                if (currentLoop != 0 || f.NodeLocations.Text != "OutputRight")
                                {
                                    //find angle in radians using Yaw
                                    double radians;

                                    if (InputLeftOuputRight == false) radians = intellObj.Yaw * Math.PI / 180;
                                    else if (currentLoop == 0) radians = (intellObj.Yaw + 90) * Math.PI / 180;
                                    else radians = (intellObj.Yaw - 90) * Math.PI / 180;

                                    // determine new facility location for node
                                    var loc = new FacilityLocation(intellObj.Location.X + (Math.Cos(radians) * nodeOffet), intellObj.Location.Y, intellObj.Location.Z + (Math.Sin(radians) * nodeOffet));

                                    // check to see if node already exists
                                    var filterListOfNodesByType = context.ActiveModel.Facility.IntelligentObjects.Where(r => r.TypeName == f.NodeType.Text);
                                    var filterListOfNodes = filterListOfNodesByType.Where(r => (r.Location.X - useExistingNodeOffset) <= loc.X && (r.Location.X + useExistingNodeOffset) >= loc.X
                                        && (r.Location.Y - useExistingNodeOffset) <= loc.Y && (r.Location.Y + useExistingNodeOffset) >= loc.Y
                                        && (r.Location.Z - useExistingNodeOffset) <= loc.Z && (r.Location.Z + useExistingNodeOffset) >= loc.Z).ToList();

                                    // if node already exist, use node, if not create node and links
                                    if (filterListOfNodes.Count > 0)
                                    {
                                        node = filterListOfNodes[0];
                                        if (node.ObjectName.Contains(intellObj.ObjectName) == false)
                                            node.ObjectName = node.ObjectName + "_" + intellObj.ObjectName;
                                    }
                                    else
                                    {
                                        node = context.ActiveModel.Facility.IntelligentObjects.CreateObject(f.NodeType.Text, loc);
                                        if (node == null) throw new Exception("Node Not Created For NodeType:" + f.NodeType.Text);
                                        node.ObjectName = node.TypeName + "_" + intellObj.ObjectName;
                                        // Add Links
                                        if (currentLoop == 0 && prevNode0 != null && ((f.Direction.Text == "LeftToRight" && node.Location.X > prevNode0.Location.X) || (f.Direction.Text != "LeftToRight" && node.Location.Z > prevNode0.Location.Z)))
                                        {
                                            var link = context.ActiveModel.Facility.IntelligentObjects.CreateLink(f.LinkType.Text, (INodeObject)prevNode0, (INodeObject)node, null);
                                            if (link == null) throw new Exception("Link Not Created For NodeType:" + f.LinkType.Text);
                                            link.ObjectName = link.TypeName + "_" + prevNode0.ObjectName + "_" + node.ObjectName;
                                        }
                                        if (currentLoop == 1 && prevNode1 != null && ((f.Direction.Text == "LeftToRight" && node.Location.X > prevNode1.Location.X) || (f.Direction.Text != "LeftToRight" && node.Location.Z > prevNode1.Location.Z)))
                                        {
                                            var link = context.ActiveModel.Facility.IntelligentObjects.CreateLink(f.LinkType.Text, (INodeObject)prevNode1, (INodeObject)node, null);
                                            if (link == null) throw new Exception("Link Not Created For NodeType:" + f.LinkType.Text);
                                            link.ObjectName = link.TypeName + "_" + prevNode1.ObjectName + "_" + node.ObjectName;
                                        }
                                        
                                    }

                                    var filterListOfLinkObjectsByType = context.ActiveModel.Facility.IntelligentObjects.Where(r => r.TypeName == f.LinkType.Text).ToList();
                                    var filterListOfLinksByType = filterListOfLinkObjectsByType.Cast<ILinkObject>().ToList();

                                    // For InputNode 
                                    if (InputLeftOuputRight == false || currentLoop == 0)
                                    {
                                        var inputNode = context.ActiveModel.Facility.IntelligentObjects["Input@" + intellObj.ObjectName];
                                        if (inputNode != null)
                                        {
                                            var filterListOfLinks = filterListOfLinksByType.Where(r => r.Begin == (INodeObject)node && r.End == (INodeObject)inputNode).ToList();
                                            if (filterListOfLinks.Count == 0)
                                            {
                                                var link = context.ActiveModel.Facility.IntelligentObjects.CreateLink(f.LinkType.Text, (INodeObject)node, (INodeObject)inputNode, null);
                                                if (link == null) throw new Exception("Link Not Created For NodeType:" + f.LinkType.Text);
                                                link.ObjectName = link.TypeName + "_" + node.ObjectName + "_" + inputNode.ObjectName;
                                            }
                                        }
                                    }

                                    // For OutputNode 
                                    if (InputLeftOuputRight == false || currentLoop == 1)
                                    {
                                        var outputNode = context.ActiveModel.Facility.IntelligentObjects["Output@" + intellObj.ObjectName];
                                        if (outputNode != null)
                                        {
                                            var filterListOfLinks = filterListOfLinksByType.Where(r => r.Begin == (INodeObject)outputNode && r.End == (INodeObject)node).ToList();
                                            if (filterListOfLinks.Count == 0)
                                            {
                                                var link = context.ActiveModel.Facility.IntelligentObjects.CreateLink(f.LinkType.Text, (INodeObject)outputNode, (INodeObject)node, null);
                                                if (link == null) throw new Exception("Link Not Created For NodeType:" + f.LinkType.Text);
                                                link.ObjectName = link.TypeName + "_" + outputNode.ObjectName + "_" + node.ObjectName;
                                            }
                                        }
                                    }

                                    if (currentLoop == 0) prevNode0 = node;
                                    else prevNode1 = node;
                                }

                            }
                        }

                        MessageBox.Show("Create Links Completed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    });
                }
            }
        }      
      
        #endregion

        #region IDesignAddInGuiDetails Members

        public string CategoryName
        {
            get { return null; }
        }

        public string TabName
        {
            get { return "Add-Ins"; }
        }

        public string GroupName
        {
            get { return "Create Nodes And Links Table Data"; }
        }

        #endregion
    }

    internal class AddNodesAndLinksToTables : IDesignAddIn, IDesignAddInGuiDetails
    {
        #region IDesignAddIn Members

        /// <summary>
        /// Property returning the name of the add-in. This name may contain any characters and is used as the display name for the add-in in the UI.
        /// </summary>
        public string Name
        {
            get { return "Add Nodes And Links To Tables"; }
        }

        /// <summary>
        /// Property returning a short description of what the add-in does.
        /// </summary>
        public string Description
        {
            get { return "Add Nodes And Links To Tables."; }
        }

        /// <summary>
        /// Property returning an icon to display for the add-in in the UI.
        /// </summary>
        public System.Drawing.Image Icon
        {
            get { return Properties.Resources.AddNodesAndLinksToTables; }
        }

        /// <summary>
        /// Method called when the add-in is run.
        /// </summary>
        public void Execute(IDesignContext context)
        {
            // This example code places some new objects from the Standard Library into the active model of the project.
            if (context.ActiveModel != null)
            {
                var tbl = context.ActiveModel.Tables["AddNodesLinksVerticesToTables"];
                if (tbl == null)
                {
                    MessageBox.Show("AddNodesLinksVerticesToTables Table Does Not Exists.  Please create table before running this add-in.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (tbl.Rows.Count == 0)
                {
                    tbl.Rows.Create();
                }
                if (tbl.Rows.Count > 1)
                {
                    MessageBox.Show("AddNodesLinksVerticesToTables Table Contains More Than One Row.   Only the first row will be used.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                var f = new AddNodesAndLinksToTablesForm();
                var row = tbl.Rows[0];
                f.LinkType.Text = row.Properties["LinkType"].Value;
                f.LinkPropertyName.Text = row.Properties["LinkPropertyName"].Value;
                f.LinkPropertyValue.Text = row.Properties["LinkPropertyValue"].Value;
                f.NodesTable.Text = row.Properties["NodesTable"].Value;
                f.NodeColumnName.Text = row.Properties["NodeColumnName"].Value;
                f.NodeTypeColumnName.Text = row.Properties["NodeTypeColumnName"].Value;
                f.NodeXColumnName.Text = row.Properties["NodeXColumnName"].Value;
                f.NodeYColumnName.Text = row.Properties["NodeYColumnName"].Value;
                f.NodeZColumnName.Text = row.Properties["NodeZColumnName"].Value;
                f.LinksTable.Text = row.Properties["LinksTable"].Value;
                f.LinkColumnName.Text = row.Properties["LinkColumnName"].Value;
                f.LinkTypeColumnName.Text = row.Properties["LinkTypeColumnName"].Value;
                f.StartingNodeColumnName.Text = row.Properties["StartingNodeColumnName"].Value;
                f.EndingNodeColumnName.Text = row.Properties["EndingNodeColumnName"].Value;
                f.VerticesTable.Text = row.Properties["VerticesTable"].Value;
                f.VertexLinkColumnName.Text = row.Properties["VertexLinkColumnName"].Value;
                f.VertexXColumnName.Text = row.Properties["VertexXColumnName"].Value;
                f.VertexYColumnName.Text = row.Properties["VertexYColumnName"].Value;
                f.VertexZColumnName.Text = row.Properties["VertexZColumnName"].Value;
                f.TablesUseAutoCreate.Checked = Convert.ToBoolean(row.Properties["TablesUseAutoCreate"].Value);

                f.ShowDialog();

                if (f.OkButtonSelected == true)
                {
                    context.ActiveModel.BulkUpdate(model =>
                    {                      
                        var filterListOfLinksByType = context.ActiveModel.Facility.IntelligentObjects.Where(r => r.TypeName == f.LinkType.Text).ToList();
                        if (filterListOfLinksByType.Count == 0)
                        {
                            MessageBox.Show("No Links For Type Found", "No Links For Type Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var filterListOfLinks = new List<IIntelligentObject>();
                        // If properyt defined
                        if (f.LinkPropertyName.Text.Length > 0)
                        {
                            IIntelligentObject intellObj = filterListOfLinksByType[0];
                            var prop = intellObj.Properties[f.LinkPropertyName.Text];
                            if (prop == null)
                            {
                                MessageBox.Show("Property Name Not Found On Object", "Property Name Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            if (f.LinkPropertyValue.Text.Length == 0)
                            {
                                MessageBox.Show("Property Value Not Provided", "Property Value Not Provided", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            filterListOfLinks = filterListOfLinksByType.Where(r => r.Properties[f.LinkPropertyName.Text].Value == f.LinkPropertyValue.Text).ToList();
                        }
                        else
                        {
                            filterListOfLinks = filterListOfLinksByType.ToList();

                        }
                        
                        var nodesTable = context.ActiveModel.Tables[f.NodesTable.Text];
                        var linksTable = context.ActiveModel.Tables[f.LinksTable.Text];
                        var verticesTable = context.ActiveModel.Tables[f.VerticesTable.Text];

                        foreach (ILinkObject linkObj in filterListOfLinks)
                        {
                            // if not input or output node
                            if (linkObj.Begin.ObjectName.StartsWith("Input@") == false && linkObj.Begin.ObjectName.StartsWith("Output@") == false)
                            {
                                var beginNode = nodesTable.Rows.OfType<IRow>().Where(r => r.Properties[f.NodeColumnName.Text].Value == linkObj.Begin.ObjectName).ToList();
                                if (beginNode.Count == 0)
                                {
                                    if (f.TablesUseAutoCreate.Checked)
                                    {
                                        // remove node...it might already have been removed
                                        try
                                        {
                                            context.ActiveModel.Facility.IntelligentObjects.Remove(linkObj.Begin);
                                        }
                                        catch { }
                                    }
                                    var beginRow = nodesTable.Rows.Create();
                                    beginRow.Properties[f.NodeColumnName.Text].Value = linkObj.Begin.ObjectName;
                                    beginRow.Properties[f.NodeTypeColumnName.Text].Value = linkObj.Begin.TypeName;
                                    beginRow.Properties[f.NodeXColumnName.Text].Value = linkObj.Begin.Location.X.ToString();
                                    beginRow.Properties[f.NodeYColumnName.Text].Value = linkObj.Begin.Location.Y.ToString();
                                    beginRow.Properties[f.NodeZColumnName.Text].Value = linkObj.Begin.Location.Z.ToString();
                                }
                            }

                            // if not input or output node
                            if (linkObj.End.ObjectName.StartsWith("Input@") == false && linkObj.End.ObjectName.StartsWith("Output@") == false)
                            {
                                var endNode = nodesTable.Rows.OfType<IRow>().Where(r => r.Properties[f.NodeColumnName.Text].Value == linkObj.End.ObjectName).ToList();
                                if (endNode.Count == 0)
                                {
                                    if (f.TablesUseAutoCreate.Checked)
                                    {
                                        // remove node...it might already have been removed
                                        try
                                        {
                                            context.ActiveModel.Facility.IntelligentObjects.Remove(linkObj.End);
                                        }
                                        catch { }
                                    }
                                    var endRow = nodesTable.Rows.Create();
                                    endRow.Properties[f.NodeColumnName.Text].Value = linkObj.End.ObjectName;
                                    endRow.Properties[f.NodeTypeColumnName.Text].Value = linkObj.End.TypeName;
                                    endRow.Properties[f.NodeXColumnName.Text].Value = linkObj.End.Location.X.ToString();
                                    endRow.Properties[f.NodeYColumnName.Text].Value = linkObj.End.Location.Y.ToString();
                                    endRow.Properties[f.NodeZColumnName.Text].Value = linkObj.End.Location.Z.ToString();
                                }
                            }

                            var link = linksTable.Rows.OfType<IRow>().Where(r => r.Properties[f.LinkColumnName.Text].Value == linkObj.ObjectName).ToList();
                            if (link.Count == 0)
                            {
                                // remove link...it might already have been removed
                                try
                                {
                                    context.ActiveModel.Facility.IntelligentObjects.Remove(linkObj);
                                }
                                catch { }
                                var endRow = linksTable.Rows.Create();
                                endRow.Properties[f.LinkColumnName.Text].Value = linkObj.ObjectName;
                                endRow.Properties[f.LinkTypeColumnName.Text].Value = linkObj.TypeName;
                                endRow.Properties[f.StartingNodeColumnName.Text].Value = linkObj.Begin.ObjectName;
                                endRow.Properties[f.EndingNodeColumnName.Text].Value = linkObj.End.ObjectName;

                                if (linkObj.InteriorVertices != null && linkObj.InteriorVertices.Count > 0)
                                {
                                    foreach (FacilityLocation vertFL in linkObj.InteriorVertices)
                                    {
                                        var vertRow = verticesTable.Rows.Create();
                                        vertRow.Properties[f.VertexLinkColumnName.Text].Value = linkObj.ObjectName;
                                        vertRow.Properties[f.VertexXColumnName.Text].Value = vertFL.X.ToString();
                                        vertRow.Properties[f.VertexYColumnName.Text].Value = vertFL.Y.ToString();
                                        vertRow.Properties[f.VertexZColumnName.Text].Value = vertFL.Z.ToString();
                                    }
                                }
                            }                            
                        }                         
                                                
                        MessageBox.Show("Node, Links and Vertices Added To Tables Completed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    });
                }
            }
        }

        #endregion

        #region IDesignAddInGuiDetails Members

        public string CategoryName
        {
            get { return null; }
        }

        public string TabName
        {
            get { return "Add-Ins"; }
        }

        public string GroupName
        {
            get { return "Create Nodes And Links Table Data"; }
        }

        #endregion
    }

    internal class MoveNodesToObjectEdges : IDesignAddIn, IDesignAddInGuiDetails
    {
        #region IDesignAddIn Members

        /// <summary>
        /// Property returning the name of the add-in. This name may contain any characters and is used as the display name for the add-in in the UI.
        /// </summary>
        public string Name
        {
            get { return "Move Nodes To Object Edges"; }
        }

        /// <summary>
        /// Property returning a short description of what the add-in does.
        /// </summary>
        public string Description
        {
            get { return "Move Nodes To Object Edges."; }
        }

        /// <summary>
        /// Property returning an icon to display for the add-in in the UI.
        /// </summary>
        public System.Drawing.Image Icon
        {
            get { return Properties.Resources.MoveNodesToObjectEdges; }
        }

        /// <summary>
        /// Method called when the add-in is run.
        /// </summary>
        public void Execute(IDesignContext context)
        {
            // This example code places some new objects from the Standard Library into the active model of the project.
            if (context.ActiveModel != null)
            {
                var tbl = context.ActiveModel.Tables["MoveNodesToObjectEdges"];
                if (tbl == null)
                {
                    MessageBox.Show("MoveNodesToObjectEdges Table Does Not Exists.  Please create table before running this add-in.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (tbl.Rows.Count == 0)
                {
                    tbl.Rows.Create();
                }
                if (tbl.Rows.Count > 1)
                {
                    MessageBox.Show("MoveNodesToObjectEdges Table Contains More Than One Row.   Only the first row will be used.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                var f = new MoveNodesToObjectEdgesForm();
                var row = tbl.Rows[0];
                f.ObjectType.Text = row.Properties["ObjectType"].Value;
                f.ShowDialog();

                if (f.OkButtonSelected == true)
                {
                    context.ActiveModel.BulkUpdate(model =>
                    {

                        var filterListOfObjectsByType = context.ActiveModel.Facility.IntelligentObjects.Where(r => r.TypeName == f.ObjectType.Text).ToList();

                        if (filterListOfObjectsByType.Count == 0)
                        {
                            MessageBox.Show("No Objects For Type Found", "No Objects For Type Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        
                        foreach (IIntelligentObject intellObj in filterListOfObjectsByType)
                        {
                            //find angles using Yaw
                            double inputAngle = (intellObj.Yaw + 90) * Math.PI / 180;
                            double outputAngle = (intellObj.Yaw - 90) * Math.PI / 180;
                            double halfWidth = intellObj.Size.Length / 2;
                            var inputLoc = new FacilityLocation(intellObj.Location.X + (Math.Cos(inputAngle) * halfWidth), intellObj.Location.Y, intellObj.Location.Z + (Math.Sin(inputAngle) * halfWidth));
                            var outputloc = new FacilityLocation(intellObj.Location.X + (Math.Cos(outputAngle) * halfWidth), intellObj.Location.Y, intellObj.Location.Z + (Math.Sin(outputAngle) * halfWidth));

                            //updated input node location
                            var inputNode = context.ActiveModel.Facility.IntelligentObjects["Input@" + intellObj.ObjectName];
                            if (inputNode != null)
                            {
                                inputNode.Location = inputLoc;
                            }

                            //updated output node location
                            var outputNode = context.ActiveModel.Facility.IntelligentObjects["Output@" + intellObj.ObjectName];
                            if (outputNode != null)
                            {
                                outputNode.Location = outputloc;
                            }
                        }
                        
                    });
                    MessageBox.Show("Move Nodes To Object Edges Completed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }               

            }

        }

        #endregion

        #region IDesignAddInGuiDetails Members

        public string CategoryName
        {
            get { return null; }
        }

        public string TabName
        {
            get { return "Add-Ins"; }
        }

        public string GroupName
        {
            get { return "Create Nodes And Links Table Data"; }
        }

        #endregion
    }
}
