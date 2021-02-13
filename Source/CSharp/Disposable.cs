using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CSharp
{
    public class Disposable :IDisposable
    {
        private bool isDisposed = false;
        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (isDisposed) return;

            if(disposing)
            {
                // Free Managed Code Here
            }

            // Free un-Managed Code Here

            isDisposed = true;
        }
    }

    public class DerivedDisposable : Disposable
    {
        private bool isDisposed = false;
        ~DerivedDisposable()
        {
            Dispose(false);
        }

        protected override void Dispose(bool disposing)
        {
            if (isDisposed) return;

            if (disposing)
            {
                // Free Managed Code Here
            }

            // Free un-Managed Code Here

            isDisposed = true;

            base.Dispose(disposing);
        }
    }

    public class SafeFileHandle : SafeHandle
    {
        public SafeFileHandle(IntPtr ptr, bool ownsHandle) : base(ptr, ownsHandle)
        {

        }

        public override bool IsInvalid => throw new NotImplementedException();

        protected override bool ReleaseHandle()
        {
            throw new NotImplementedException();
        }
    }

    public class DisposableSafe : IDisposable
    {
        private bool isDisposed = false;

        private SafeHandle _safeHandle = new SafeFileHandle(IntPtr.Zero, true);

        public void Dispose() => Dispose(true);
        protected virtual void Dispose(bool disposing)
        {
            if (isDisposed) return;

            if(disposing)
            {
                _safeHandle?.Dispose();
            }

            isDisposed = true;
        }
    }

    public class DerivedDisposableSafe : DisposableSafe
    {
        private bool isDisposed = false;
        private SafeHandle _safeHandle = new SafeFileHandle(IntPtr.Zero, true);
        protected override void Dispose(bool disposing)
        {
            if (isDisposed) return;

            if(disposing)
            {
                _safeHandle?.Dispose();
            }
            isDisposed = true;
            
            base.Dispose(disposing);
        }

    }
}
