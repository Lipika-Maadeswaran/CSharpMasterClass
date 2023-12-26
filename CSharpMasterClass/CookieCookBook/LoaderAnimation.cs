using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCookBook
{
    internal class LoaderAnimation
    {
        private int _currentAnimationFrame;

        public LoaderAnimation()
        {
            SpinnerAnimationFrames = new[]
                                     {
                                         '|',
                                         '/',
                                         '-',
                                         '\\'
                                     };
        }

        public char[] SpinnerAnimationFrames { get; set; }

        public void UpdateProgress()
        {
            Console.CursorVisible = false;
            var originalX = Console.CursorLeft;
            var originalY = Console.CursorTop;

            Console.Write(SpinnerAnimationFrames[_currentAnimationFrame]);

            _currentAnimationFrame++;
            if (_currentAnimationFrame == SpinnerAnimationFrames.Length)
            {
                _currentAnimationFrame = 0;
            }

            Console.SetCursorPosition(originalX, originalY);
        }
    }
}

