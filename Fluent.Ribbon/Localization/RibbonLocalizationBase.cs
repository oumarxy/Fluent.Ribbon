﻿namespace Fluent.Localization
{
    /// <summary>
    /// Base class for localizations.
    /// </summary>
    public abstract class RibbonLocalizationBase
    {
        /// <summary>
        /// Gets or sets text of backstage button
        /// </summary>
        public abstract string BackstageButtonText { get; }

        /// <summary>
        /// Gets or sets KeyTip of backstage button
        /// </summary>
        public abstract string BackstageButtonKeyTip { get; }

        /// <summary>
        /// Minimize Button ScreenTip Title
        /// </summary>
        public abstract string MinimizeButtonScreenTipTitle { get; }

        /// <summary>
        /// Minimize Button ScreenTip Text
        /// </summary>
        public abstract string MinimizeButtonScreenTipText { get; }

        /// <summary>
        /// Expand Button ScreenTip Title
        /// </summary>
        public abstract string ExpandButtonScreenTipTitle { get; }

        /// <summary>
        /// Expand Button ScreenTip Text
        /// </summary>
        public abstract string ExpandButtonScreenTipText { get; }

        /// <summary>
        /// Quick Access ToolBar DropDown Button ToolTip
        /// </summary>
        public abstract string QuickAccessToolBarDropDownButtonTooltip { get; }

        /// <summary>
        /// Quick Access ToolBar MoreControls Button ToolTip
        /// </summary>
        public abstract string QuickAccessToolBarMoreControlsButtonTooltip { get; }

        /// <summary>
        /// Quick Access ToolBar  Menu Header
        /// </summary>
        public abstract string QuickAccessToolBarMenuHeader { get; }

        /// <summary>
        /// Quick Access ToolBar Menu Minimize Quick Access Toolbar
        /// </summary>
        public abstract string QuickAccessToolBarMenuShowAbove { get; }

        /// <summary>
        /// Quick Access ToolBar Minimize Quick Access Toolbar
        /// </summary>
        public abstract string QuickAccessToolBarMenuShowBelow { get; }

        /// <summary>
        /// Quick Access ToolBar Menu Add Item
        /// </summary>
        public abstract string RibbonContextMenuAddItem { get; }

        /// <summary>
        /// Quick Access ToolBar Menu Add Group
        /// </summary>
        public abstract string RibbonContextMenuAddGroup { get; }

        /// <summary>
        /// Quick Access ToolBar Menu Add Gallery
        /// </summary>
        public abstract string RibbonContextMenuAddGallery { get; }

        /// <summary>
        /// Quick Access ToolBar Menu Add Menu
        /// </summary>
        public abstract string RibbonContextMenuAddMenu { get; }

        /// <summary>
        /// Quick Access ToolBar Menu Remove Item
        /// </summary>
        public abstract string RibbonContextMenuRemoveItem { get; }

        /// <summary>
        /// Ribbon Context Menu Customize Quick Access Toolbar
        /// </summary>
        public abstract string RibbonContextMenuCustomizeQuickAccessToolBar { get; }

        /// <summary>
        /// Ribbon Context Menu Customize Quick Access Toolbar
        /// </summary>
        public abstract string RibbonContextMenuCustomizeRibbon { get; }

        /// <summary>
        /// Ribbon Context Menu Minimize Quick Access Toolbar
        /// </summary>
        public abstract string RibbonContextMenuMinimizeRibbon { get; }

        /// <summary>
        /// Ribbon Context Menu Minimize Quick Access Toolbar
        /// </summary>
        public abstract string RibbonContextMenuShowAbove { get; }

        /// <summary>
        /// Ribbon Context Menu Minimize Quick Access Toolbar
        /// </summary>
        public abstract string RibbonContextMenuShowBelow { get; }

        /// <summary>
        /// Gets or sets ScreenTip's disable reason header
        /// </summary>
        public abstract string ScreenTipDisableReasonHeader { get; }

        /// <summary>
        /// Gets or sets ScreenTip's disable reason header
        /// </summary>
        public abstract string ScreenTipF1LabelHeader { get; }

        /// <summary>
        /// Gets or sets customize Status Bar
        /// </summary>
        public abstract string CustomizeStatusBar { get; }
    }
}