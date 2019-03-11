// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// This file was generated by a tool. Edits to this file will be lost the next time the file is generated 
using System.Collections.Generic;
using static AccessibilityInsights.Core.Types.ControlType;

namespace AccessibilityInsights.Rules.Misc
{
    static class ControlTypeStrings
    {
        public static IReadOnlyDictionary<int, string> Dictionary;

        static ControlTypeStrings()
        {
            var d = new Dictionary<int, string>();

			d[UIA_AppBarControlTypeId] = "AppBar";
			d[UIA_ButtonControlTypeId] = "Button";
			d[UIA_CalendarControlTypeId] = "Calendar";
			d[UIA_CheckBoxControlTypeId] = "CheckBox";
			d[UIA_ComboBoxControlTypeId] = "ComboBox";
			d[UIA_CustomControlTypeId] = "Custom";
			d[UIA_DataGridControlTypeId] = "DataGrid";
			d[UIA_DataItemControlTypeId] = "DataItem";
			d[UIA_DocumentControlTypeId] = "Document";
			d[UIA_EditControlTypeId] = "Edit";
			d[UIA_GroupControlTypeId] = "Group";
			d[UIA_HeaderControlTypeId] = "Header";
			d[UIA_HeaderItemControlTypeId] = "HeaderItem";
			d[UIA_HyperlinkControlTypeId] = "Hyperlink";
			d[UIA_ImageControlTypeId] = "Image";
			d[UIA_ListControlTypeId] = "List";
			d[UIA_ListItemControlTypeId] = "ListItem";
			d[UIA_MenuBarControlTypeId] = "MenuBar";
			d[UIA_MenuControlTypeId] = "Menu";
			d[UIA_MenuItemControlTypeId] = "MenuItem";
			d[UIA_PaneControlTypeId] = "Pane";
			d[UIA_ProgressBarControlTypeId] = "ProgressBar";
			d[UIA_RadioButtonControlTypeId] = "RadioButton";
			d[UIA_ScrollBarControlTypeId] = "ScrollBar";
			d[UIA_SemanticZoomControlTypeId] = "SemanticZoom";
			d[UIA_SeparatorControlTypeId] = "Separator";
			d[UIA_SliderControlTypeId] = "Slider";
			d[UIA_SpinnerControlTypeId] = "Spinner";
			d[UIA_SplitButtonControlTypeId] = "SplitButton";
			d[UIA_StatusBarControlTypeId] = "StatusBar";
			d[UIA_TabControlTypeId] = "Tab";
			d[UIA_TabItemControlTypeId] = "TabItem";
			d[UIA_TableControlTypeId] = "Table";
			d[UIA_TextControlTypeId] = "Text";
			d[UIA_ThumbControlTypeId] = "Thumb";
			d[UIA_TitleBarControlTypeId] = "TitleBar";
			d[UIA_ToolBarControlTypeId] = "ToolBar";
			d[UIA_ToolTipControlTypeId] = "ToolTip";
			d[UIA_TreeControlTypeId] = "Tree";
			d[UIA_TreeItemControlTypeId] = "TreeItem";
			d[UIA_WindowControlTypeId] = "Window";
			
            ControlTypeStrings.Dictionary = d;
        }
    } // class
} // namespace