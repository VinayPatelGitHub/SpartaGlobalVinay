using System;
using System.Collections.Generic;

namespace HMWK_SQLinCsharp_Mon
{
    public partial class FilmTable
    {
        public int FilmId { get; set; }
        public string FilmName { get; set; }
        public string FilmType { get; set; }
        public DateTime? DateOfRelease { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Star { get; set; }
        public string FilmLanguage { get; set; }
        public string OfficalWebsite { get; set; }
        public string PlotSummart { get; set; }
    }
}
