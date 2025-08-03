using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsConcepts.TreeViewAndImageList;

public partial class TreeViewAndImageList : Form {
    public TreeViewAndImageList() {
        InitializeComponent();
    }

    private void TreeViewAndImageList_Load(
        object    sender,
        EventArgs e
    ) {
        nodes.CheckBoxes = true;

        const string PATH = "D:\\Projects\\Learn\\ProgrammingAdvices\\CS-Level-1-by-Programming-Advices\\WindowsFormsConcepts\\TreeViewAndImageList\\resources\\";

        imageListSample.Images.Add(
            "audio",
            Image.FromFile(
                PATH + "FileAudio.png"
            )
        );
        imageListSample.Images.Add(
            "image",
            Image.FromFile(
                PATH + "FileImage.png"
            )
        );
        imageListSample.Images.Add(
            "text",
            Image.FromFile(
                PATH + "FileText.png"
            )
        );
        imageListSample.Images.Add(
            "video",
            Image.FromFile(
                PATH + "FileVideo.png"
            )
        );
        imageListSample.Images.Add(
            "folder",
            Image.FromFile(
                PATH + "Folder.png"
            )
        );
        imageListSample.Images.Add(
            "folderNew",
            Image.FromFile(
                PATH + "FolderNew.png"
            )
        );
        imageListSample.Images.Add(
            "folderSearchFind",
            Image.FromFile(
                PATH + "FolderSearchFind.png"
            )
        );

        nodes.ImageList = imageListSample;

        TreeNode firstFolder = new TreeNode(
            "First Folder",
            4,
            4
        );
        firstFolder.Nodes.Add(
            new TreeNode(
                "Audio File",
                0,
                0
            )
        );
        firstFolder.Nodes.Add(
            new TreeNode(
                "First Text File",
                2,
                2
            )
        );
        firstFolder.Nodes.Add(
            new TreeNode(
                "Second Text File",
                2,
                2
            )
        );
        firstFolder.Nodes.Add(
            new TreeNode(
                "Third Text File",
                2,
                2
            )
        );
        firstFolder.Nodes.Add(
            new TreeNode(
                "Video File",
                3,
                3
            )
        );

        TreeNode secondFolder = new TreeNode(
            "Second Folder",
            5,
            5
        );

        TreeNode thirdFolder = new TreeNode(
            "Third Folder",
            4,
            4
        );
        thirdFolder.Nodes.Add(
            new TreeNode(
                "First Image File",
                1,
                1
            )
        );
        thirdFolder.Nodes.Add(
            new TreeNode(
                "Audio File",
                0,
                0
            )
        );
        thirdFolder.Nodes.Add(
            new TreeNode(
                "Second Image File",
                1,
                1
            )
        );
        firstFolder.Nodes.Add(
            thirdFolder
        );

        nodes.Nodes.Add(
            firstFolder
        );
        nodes.Nodes.Add(
            secondFolder
        );
        nodes.ExpandAll();
    }

    private void nodes_AfterExpand(
        object            sender,
        TreeViewEventArgs e
    ) {
        e.Node!.ImageKey        = @"folderSearchFind";
        e.Node.SelectedImageKey = @"folderSearchFind";
    }

    private void nodes_AfterCollapse(
        object            sender,
        TreeViewEventArgs e
    ) {
        e.Node!.ImageKey        = @"folder";
        e.Node.SelectedImageKey = @"folder";
    }

    private void nodes_AfterCheck(
        object            sender,
        TreeViewEventArgs e
    ) {
        checkAllNodes(
            e.Node!,
            e.Node!.Checked
        );
    }

    private static void checkAllNodes(
        TreeNode root,
        bool     isChecked
    ) {
        foreach (TreeNode node in root.Nodes) {
            node.Checked = isChecked;
            if (node.Nodes.Count > 0)
                checkAllNodes(
                    node,
                    isChecked
                );
        }
    }
}