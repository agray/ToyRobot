#region Licence
/*
 * The MIT License
 *
 * Copyright (c) 2014, Andrew Gray
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */
#endregion

using System;

namespace ToyRobot {
    public class Constants {
        public static const String TAG_LINE = "WELCOME TO TOY ROBOT!";
        public static const String INITIAL_INSTRUCTION = "Execute commands or type HELP for more information.";
        public static const String PLACE_HELP = "PLACE X,Y,F: Place robot on table with position X,Y and direction F.";
        public static const String MOVE_HELP = "MOVE: Move the robot forward one grid place in direction currently facing.";
        public static const String RIGHT_HELP = "RIGHT: Turn robot 90 degrees right.";
        public static const String LEFT_HELP = "LEFT: Turn robot 90 degrees left.";
        public static const String REPORT_HELP = "REPORT: Report current position and direction faced.";
        public static const String HELP_HELP = "HELP: Print this help.";
        public static const String EXIT_HELP = "EXIT: Exit this application.";

        public static const String NORTH = "N";
        public static const String SOUTH = "S";
        public static const String EAST = "E";
        public static const String WEST = "W";

        public static const String REPORT = "REPORT";
        public static const String MOVE = "MOVE";
        public static const String EXIT = "EXIT";
        public static const String HELP = "HELP";
        public static const String LEFT = "LEFT";
        public static const String RIGHT = "RIGHT";
        public static const String PLACE = "PLACE";

        public static const char COMMA_CHAR = ',';
        public static const char SPACE_CHAR = ' ';
    }
}
