/*
    metro_redux_launcher: A simple script to run the Metro 2033 and Last Light Redux avoiding the Steam auto update if there are modified files in the game.

    Copyright (C) 2017  Lucas Cota (BrasileiroGamer)
    lucasbrunocota@live.com
    <http://www.github.com/BrasileiroGamer/>

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

/*
 *	metro_redux_launcher.cs
 *	Author: Lucas Cota (BrasileiroGamer)
 *	Description: Metro 2033 and Last Light process start bypassing the Steam auto updater.
 *  Date: 2017-06-03
 */

using System;
using System.Diagnostics;

namespace MatcherSort
{
    class Program
    {
        static void Main(string[] args)
        {
        	Process.Start("metro.exe");
        }
    }
}
