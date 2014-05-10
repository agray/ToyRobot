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
        public const String TAG_LINE = "WELCOME TO TOY ROBOT!";
        public const String INITIAL_INSTRUCTION = "Execute UPPERCASE commands (type HELP for list of available commands).";
        public const String INVALID_INPUT = "Invalid command, try again...";
        public const String AVAILABLE_COMMANDS = "AVAILABLE COMMANDS:";
        public const String PLACE_HELP = "PLACE X,Y,F: Place robot on table with position X,Y and direction F.";
        public const String MOVE_HELP = "MOVE: Move the robot forward one grid place in direction currently facing.";
        public const String RIGHT_HELP = "RIGHT: Turn robot 90 degrees right.";
        public const String LEFT_HELP = "LEFT: Turn robot 90 degrees left.";
        public const String REPORT_HELP = "REPORT: Report current position and direction faced.";
        public const String HELP_HELP = "HELP: Print this help.";
        public const String EXIT_HELP = "EXIT: Exit this application.";

        public const String NORTH = "N";
        public const String SOUTH = "S";
        public const String EAST = "E";
        public const String WEST = "W";

        public const String REPORT = "REPORT";
        public const String MOVE = "MOVE";
        public const String EXIT = "EXIT";
        public const String HELP = "HELP";
        public const String LEFT = "LEFT";
        public const String RIGHT = "RIGHT";
        public const String PLACE = "PLACE";

        public const char COMMA_CHAR = ',';
        public const char SPACE_CHAR = ' ';
    }
}
