// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EditTrimWhitespacesCommandContainer.cs" company="WildGums">
//   Copyright (c) 2008 - 2017 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace CsvTextEditor
{
    using Catel.IoC;
    using Catel.MVVM;
    using Orc.ProjectManagement;

    public class EditTrimWhitespacesCommandContainer : EditProjectCommandContainerBase
    {
        #region Constructors
        public EditTrimWhitespacesCommandContainer(ICommandManager commandManager, IProjectManager projectManager, IServiceLocator serviceLocator)
            : base(Commands.Edit.TrimWhitespaces, commandManager, projectManager, serviceLocator)
        {
        }

        #endregion

        #region Methods

        protected override void Execute(object parameter)
        {
            CsvTextEditorService.TrimWhitespaces();

            base.Execute(parameter);
        }
        #endregion
    }
}