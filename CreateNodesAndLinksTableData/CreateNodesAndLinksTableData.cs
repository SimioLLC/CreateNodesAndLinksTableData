﻿using SimioAPI;
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
            get { return "Create Tables"; }
        }

        /// <summary>
        /// Property returning a short description of what the add-in does.
        /// </summary>
        public string Description
        {
            get { return "Create Tables."; }
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
                // Add Routing Type List
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
                    secondRow.Properties[0].Value = "TopToBottom";
                    MessageBox.Show("CreateNodesAndLinksDirection List Created");
                }                

                var tbl = context.ActiveModel.Tables["CreateNodesAndLinks"];
                if (tbl != null)
                {
                    MessageBox.Show("CreateNodesAndLinks Table Already Exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    tbl = context.ActiveModel.Tables.Create("CreateNodesAndLinks");
                    var s = tbl.Columns.AddStringColumn("ObjectType", "Rack");
                    s = tbl.Columns.AddStringColumn("ObjectPropertyName", "Filter");
                    s = tbl.Columns.AddStringColumn("ObjectPropertyValue", "Create1");
                    s = tbl.Columns.AddStringColumn("NodeType", "BasicNode");
                    s = tbl.Columns.AddStringColumn("LinkType", "RackPath");
                    var l = tbl.Columns.AddListReferenceColumn("Direction");
                    l.ListName = "CreateNodesAndLinksDirection";
                    l.DefaultString = "LeftToRight";
                    var r = tbl.Columns.AddRealColumn("NodeOffset", 1.5);
                    (r as IUnitizedTableColumn).UnitType = SimioUnitType.Length;
                    r = tbl.Columns.AddRealColumn("UseExistingNodeOffset", 0.5);
                    (r as IUnitizedTableColumn).UnitType = SimioUnitType.Length;
                    var row = tbl.Rows.Create();
                    MessageBox.Show("CreateNodesAndLinksTableData Table Created");
                }

                tbl = context.ActiveModel.Tables["AddNodesAndLinksToTables"];
                if (tbl != null)
                {
                    MessageBox.Show("AddNodesAndLinksToTables Table Already Exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    tbl = context.ActiveModel.Tables.Create("AddNodesAndLinksToTables");
                    var t = tbl.Columns.AddTableReferenceColumn("NodesTable");
                    t.DefaultString = "Nodes";
                    var s = tbl.Columns.AddStringColumn("NodeColumnName", "Node");
                    s = tbl.Columns.AddStringColumn("NodeTypeColumnName", "NodeType");
                    s = tbl.Columns.AddStringColumn("XLocationColumnName", "XLoc");
                    s = tbl.Columns.AddStringColumn("YLocationColumnName", "YLoc");
                    s = tbl.Columns.AddStringColumn("ZLocationColumnName", "ZLoc");
                    t = tbl.Columns.AddTableReferenceColumn("LinksTable");
                    t.DefaultString = "Links";
                    s = tbl.Columns.AddStringColumn("LinkColumnName", "Link");
                    s = tbl.Columns.AddStringColumn("LinkTypeColumnName", "Type");
                    s = tbl.Columns.AddStringColumn("StartingNodeColumnName", "StartingNode");
                    s = tbl.Columns.AddStringColumn("EndingNodeColumnName", "EndingNode");
                    s = tbl.Columns.AddStringColumn("LinkType", "RackPath");
                    s = tbl.Columns.AddStringColumn("LinkPropertyName", "Filter");
                    s = tbl.Columns.AddStringColumn("LinkPropertyValue", "Create1");
                    var row = tbl.Rows.Create();
                    MessageBox.Show("AddNodesAndLinksToTables Table Created");
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
                f.Direction.Text = row.Properties["Direction"].Value;
                f.ShowDialog();

                if (f.OkButtonSelected == true)
                {
                    context.ActiveModel.BulkUpdate(model =>
                    {
                        var filterListOfObjectsByType = context.ActiveModel.Facility.IntelligentObjects.Where(r => r.TypeName == f.ObjectType.Text);
                        var filterListOfObjects = filterListOfObjectsByType.Where(r => r.Properties[f.ObjectPropertyName.Text].Value == f.ObjectPropertyValue.Text).ToList();
                        var sortedListOfObjects = new List<IIntelligentObject>();
                        if (f.Direction.Text == "LeftToRight") sortedListOfObjects = filterListOfObjects.OrderBy(z => z.Location.Z).ThenBy(y => y.Location.Y).ThenBy(x => x.Location.X).ToList();
                        else sortedListOfObjects = filterListOfObjects.OrderBy(x => x.Location.X).ThenBy(y => y.Location.Y).ThenBy(z => z.Location.Z).ToList();

                        IIntelligentObject prevNode = null;
                        IIntelligentObject node = null;
                        double useExistingNodeOffset = Convert.ToDouble(f.UseExistingNodeOffset.Text);
                        double nodeOffet = Convert.ToDouble(f.NodeOffset.Text);

                        foreach (IIntelligentObject intellObj in sortedListOfObjects)
                        {
                            //find angle using Yaw
                            double angle = intellObj.Yaw * Math.PI / 180;

                            // determine new facility location for node
                            var loc = new FacilityLocation(intellObj.Location.X + (Math.Cos(angle) * nodeOffet), intellObj.Location.Y, intellObj.Location.Z + (Math.Sin(angle) * nodeOffet));

                            // check to see if node already exists
                            var filterListOfNodesByType = context.ActiveModel.Facility.IntelligentObjects.Where(r => r.TypeName == f.NodeType.Text);
                            var filterListOfNodes = filterListOfNodesByType.Where(r => (r.Location.X - useExistingNodeOffset) <= loc.X && (r.Location.X + useExistingNodeOffset) >= loc.X && (r.Location.Z - useExistingNodeOffset) <= loc.Z && (r.Location.Z + useExistingNodeOffset) >= loc.Z).ToList();

                            // if node already exist, use node, if not create node and links
                            if (filterListOfNodes.Count > 0) node = filterListOfNodes[0];
                            else
                            {
                                node = context.ActiveModel.Facility.IntelligentObjects.CreateObject(f.NodeType.Text, loc);
                                // Add Links
                                if ( prevNode != null && ((f.Direction.Text == "LeftToRight" && node.Location.X > prevNode.Location.X) || (f.Direction.Text != "LeftToRight" && node.Location.Z > prevNode.Location.Z)))
                                {
                                    context.ActiveModel.Facility.IntelligentObjects.CreateLink(f.LinkType.Text, (INodeObject)prevNode, (INodeObject)node, null);
                                }
                            }

                            var filterListOfLinkObjectsByType = context.ActiveModel.Facility.IntelligentObjects.Where(r => r.TypeName == f.LinkType.Text).ToList();
                            var filterListOfLinksByType = filterListOfLinkObjectsByType.Cast<ILinkObject>().ToList();

                            var inputNode = context.ActiveModel.Facility.IntelligentObjects["Input@" + intellObj.ObjectName];
                            if (inputNode != null)
                            {
                                var filterListOfLinks = filterListOfLinksByType.Where(r => r.Begin == (INodeObject)node && r.End == (INodeObject)inputNode).ToList();
                                if (filterListOfLinks.Count == 0) 
                                    context.ActiveModel.Facility.IntelligentObjects.CreateLink(f.LinkType.Text, (INodeObject)node, (INodeObject)inputNode, null);
                            }

                            var outputNode = context.ActiveModel.Facility.IntelligentObjects["Output@" + intellObj.ObjectName];
                            if (outputNode != null)
                            {
                                var filterListOfLinks = filterListOfLinksByType.Where(r => r.Begin == (INodeObject)outputNode && r.End == (INodeObject)node).ToList();
                                if (filterListOfLinks.Count == 0)
                                    context.ActiveModel.Facility.IntelligentObjects.CreateLink(f.LinkType.Text, (INodeObject)outputNode, (INodeObject)node, null);
                            }

                            prevNode = node;
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
                var tbl = context.ActiveModel.Tables["AddNodesAndLinksToTables"];
                if (tbl == null)
                {
                    MessageBox.Show("AddNodesAndLinksToTables Table Does Not Exists.  Please create table before running this add-in.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                var f = new AddNodesAndLinksToTablesForm();
                var row = tbl.Rows[0];
                f.NodesTable.Text = row.Properties["NodesTable"].Value;
                f.NodeColumnName.Text = row.Properties["NodeColumnName"].Value;
                f.NodeTypeColumnName.Text = row.Properties["NodeTypeColumnName"].Value;
                f.XLocationColumnName.Text = row.Properties["XLocationColumnName"].Value;
                f.YLocationColumnName.Text = row.Properties["YLocationColumnName"].Value;
                f.ZLocationColumnName.Text = row.Properties["ZLocationColumnName"].Value;
                f.LinksTable.Text = row.Properties["LinksTable"].Value;
                f.LinkColumnName.Text = row.Properties["LinkColumnName"].Value;
                f.LinkTypeColumnName.Text = row.Properties["LinkTypeColumnName"].Value;
                f.StartingNodeColumnName.Text = row.Properties["StartingNodeColumnName"].Value;
                f.EndingNodeColumnName.Text = row.Properties["EndingNodeColumnName"].Value;
                f.LinkType.Text = row.Properties["LinkType"].Value;
                f.LinkPropertyName.Text = row.Properties["LinkPropertyName"].Value;
                f.LinkPropertyValue.Text = row.Properties["LinkPropertyValue"].Value;

                f.ShowDialog();

                if (f.OkButtonSelected == true)
                {
                    context.ActiveModel.BulkUpdate(model =>
                    {
                        var filterListOfLinksByType = context.ActiveModel.Facility.IntelligentObjects.Where(r => r.TypeName == f.LinkType.Text);
                        var filterListOfLinks = filterListOfLinksByType.Where(r => r.Properties[f.LinkPropertyName.Text].Value == f.LinkPropertyValue.Text).ToList();
                        var nodesTable = context.ActiveModel.Tables[f.NodesTable.Text];
                        var linksTable = context.ActiveModel.Tables[f.LinksTable.Text];

                        foreach (ILinkObject linkObj in filterListOfLinks)
                        {
                            // if not input or output node
                            if (linkObj.Begin.ObjectName.StartsWith("Input@") == false && linkObj.Begin.ObjectName.StartsWith("Output@") == false)
                            {
                                var beginNode = nodesTable.Rows.OfType<IRow>().Where(r => r.Properties[f.NodeColumnName.Text].Value == linkObj.Begin.ObjectName).ToList();
                                if (beginNode.Count == 0)
                                {
                                    // remove node...it might already have been removed
                                    try
                                    {
                                        context.ActiveModel.Facility.IntelligentObjects.Remove(linkObj.Begin);
                                    }
                                    catch { }
                                    var beginRow = nodesTable.Rows.Create();
                                    beginRow.Properties[f.NodeColumnName.Text].Value = linkObj.Begin.ObjectName;
                                    beginRow.Properties[f.NodeTypeColumnName.Text].Value = linkObj.Begin.TypeName;
                                    beginRow.Properties[f.XLocationColumnName.Text].Value = linkObj.Begin.Location.X.ToString();
                                    beginRow.Properties[f.YLocationColumnName.Text].Value = linkObj.Begin.Location.Y.ToString();
                                    beginRow.Properties[f.ZLocationColumnName.Text].Value = linkObj.Begin.Location.Z.ToString();
                                }
                            }

                            // if not input or output node
                            if (linkObj.End.ObjectName.StartsWith("Input@") == false && linkObj.End.ObjectName.StartsWith("Output@") == false)
                            {
                                var endNode = nodesTable.Rows.OfType<IRow>().Where(r => r.Properties[f.NodeColumnName.Text].Value == linkObj.End.ObjectName).ToList();
                                if (endNode.Count == 0)
                                {
                                    // remove node...it might already have been removed
                                    try
                                    {
                                        context.ActiveModel.Facility.IntelligentObjects.Remove(linkObj.End);
                                    }
                                    catch { }
                                    var endRow = nodesTable.Rows.Create();
                                    endRow.Properties[f.NodeColumnName.Text].Value = linkObj.End.ObjectName;
                                    endRow.Properties[f.NodeTypeColumnName.Text].Value = linkObj.End.TypeName;
                                    endRow.Properties[f.XLocationColumnName.Text].Value = linkObj.End.Location.X.ToString();
                                    endRow.Properties[f.YLocationColumnName.Text].Value = linkObj.End.Location.Y.ToString();
                                    endRow.Properties[f.ZLocationColumnName.Text].Value = linkObj.End.Location.Z.ToString();
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
                            }                            
                        }                         
                                                
                        MessageBox.Show("Node And Links Added To Tables Completed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

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
}