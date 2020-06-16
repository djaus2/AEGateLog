using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorQRCode.Data
{
    public interface IMyService
    {
        event Action RefreshRequested;
        void CallRequestRefresh();
    }

    public class MyService : IMyService
    {
        public int Id { get; set; } = 123;
        public event Action RefreshRequested;
        public void CallRequestRefresh()
        {
            RefreshRequested?.Invoke();
        }
    }

    /* 
     * //child component
MyService.CallRequestRefresh();


//parent component
MyService.RefreshRequested += RefreshMe;

private void RefreshMe()
{
    StateHasChanged();
}
     */
}
