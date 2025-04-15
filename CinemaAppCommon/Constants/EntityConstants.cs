using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAppCommon.Constants
{
    public static class EntityConstants
    {
        public const string MoneyType = "money(18,2)";

        public static class Cinema
        {
            public const int NameMaxLength = 256;
            public const int LocationMaxLength = 256;
        }

        public static class CinemaMovie
        {
            //CinemaMovie showtimes should be string with length = 5
            public const int ShowtimesMaxLength = 5;
            //Should Have default format "00000"
            public const string ShowTimesDefaultFormat = "00000";
        }

        public static class Movie
        {
            /// <summary>
            /// Movie Title should be a text with length greater than or equal to 1
            /// </summary>
            public const int TitleMinLength = 1;

            /// <summary>
            /// Movie Title should be able to store text with length up to 150
            /// </summary>
            public const int TitleMaxLength = 150;

            /// <summary>
            /// Movie Genre should be able to store text with length up to 30
            /// </summary>
            public const int GenreMaxLength = 30;

            /// <summary>
            /// Movie Director should be able to store text with length up to 150
            /// </summary>
            public const int DirectorMaxLength = 150;

            /// <summary>
            /// Movie Description should be able to store text with length up to 1024
            /// </summary>
            public const int DescriptionMaxLength = 1024;

            /// <summary>
            /// Movie ImageUrl should be able to store text with length up to 2048 (refer URI RFC)
            /// </summary>
            public const int ImageUrlMaxLength = 2048;
        }

        public static class ApplicationUser
        {
            /// <summary>
            /// User email should be used as a username. User email should have length of at least 5 characters
            /// </summary>
            public const int UsernameMinLength = 5;

            /// <summary>
            /// User email should be used as a username. User email can have length up to 256 characters
            /// </summary>
            public const int UsernameMaxLength = 256;
        }
    }
}

