using System;

namespace qrattend.Models
{

    ///f
    public class ErrorViewModel
    {
        ///f
        public string RequestId { get; set; }
        ///f
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
