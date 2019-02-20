using System;
using System.ComponentModel.DataAnnotations;

namespace JXWebHost.Models
{
    public class ErrorViewModel
    {
		[DisplayFormat(ConvertEmptyStringToNull = false)]
		public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}