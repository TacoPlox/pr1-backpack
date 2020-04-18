using System;

namespace PR1_Backpack
{
    class Backpack
    {
        private const int COLUMNS = 4;
        private const int ROWS = 3;

        BackpackItem[,] items = new BackpackItem[ROWS, COLUMNS];

        public void PrintContent () {
            for (int y = 0; y < ROWS; y++)
            {
                for (int x = 0; x < COLUMNS; x++)
                {
                    if (IsPositionValid(y, x)) {
                        BackpackItem item = this.items[y, x];
                        // Console.Write(item.initials);
                        Console.Write(item.initials.PadRight(2));
                    } else {
                        Console.Write("".PadRight(2));
                    }
                }
                Console.WriteLine();
            }
        }

        public bool IsPositionValid(int y, int x) {
            if (y == 0 && x == 0) {
                return false;
            }

            if (y == 0 && x == (COLUMNS - 1)) {
                return false;
            }

            return true;
        }

        public void AddItemAtPosition(BackpackItem itemToAdd, int y, int x) {
            if (IsPositionValid(y, x)) {
                this.items[y, x] = itemToAdd;
            }
            int n = 1;
            while (n < itemToAdd.verticalSize) {
                if (IsPositionValid(y - n, x)) {
                    this.items[y - n, x] = itemToAdd;
                }
                n++;
            }
        }

        public string CheckWeights() {
            for (int x = 0; x < COLUMNS; x++)
            {
                int weightSoFar = 0;
                string previousItemInitials = "";
                for (int y = 0; y < ROWS; y++)
                {

                    if (IsPositionValid(y, x)) {

                        BackpackItem item = this.items[y, x];

                        if (weightSoFar == 0) {
                            weightSoFar = item.weight;
                            previousItemInitials = item.initials;
                        } else {
                            if (item.initials != previousItemInitials) {
                                if (weightSoFar > item.weight) {
                                    return $"{item.name} ({item.initials}) was squashed!";
                                }
                                weightSoFar += item.weight;
                                previousItemInitials = item.initials;
                            }
                        }

                    }
                    
                }
                
            }

            return "Backpack is ok!";
        }
    }
}
