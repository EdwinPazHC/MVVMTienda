using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyMvvmViajesverdes.Core.ViewModels
{
    public abstract class BaseViewModelResult<TResult> : BaseViewModel, IMvxViewModelResult<TResult>
        where TResult : notnull
    {
        public TaskCompletionSource<object> CloseCompletionSource { get; set; }

        public override void ViewDestroy(bool viewFinishing = true)
        {
            if (viewFinishing && CloseCompletionSource?.Task.IsCompleted == false && !CloseCompletionSource.Task.IsFaulted)
                CloseCompletionSource?.TrySetCanceled();

            base.ViewDestroy(viewFinishing);
        }
    }
}
