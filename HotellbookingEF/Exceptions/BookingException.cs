using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotellbookingEF.Exceptions
{
    public class BookingException : KeyNotFoundException
    {
        public int VideoId { get; private set; }
        public BookingException(int videoId = 0, string message = "Could not find rental booking") : base(message)
        {
            VideoId = videoId;
        }
    }
}
