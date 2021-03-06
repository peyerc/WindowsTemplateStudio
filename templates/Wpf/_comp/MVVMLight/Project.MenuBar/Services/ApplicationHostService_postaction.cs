﻿namespace Param_RootNamespace.Services
{
    public class ApplicationHostService : IApplicationHostService
    {
        private readonly INavigationService _navigationService;
//{[{
        private readonly IRightPaneService _rightPaneService;
//}]}
        public ApplicationHostService(/*{[{*/IRightPaneService rightPaneService/*}]}*/)
        {
//^^
//{[{
            _rightPaneService = rightPaneService;
//}]}
        }

        public async Task StartAsync()
        {
            _navigationService.Initialize(_shellWindow.GetNavigationFrame());
//{[{
            _rightPaneService.Initialize(_shellWindow.GetRightPaneFrame(), _shellWindow.GetSplitView());
//}]}
            _shellWindow.ShowWindow();
        }
    }
}