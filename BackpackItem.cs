using System;

namespace PR1_Backpack
{
    class BackpackItem
    {
        public string initials;

        public string name;

        public int weight;

        public int verticalSize = 1;

        public BackpackItem(string initials, string name, int weight) {
            this.initials = initials;
            this.name = name;
            this.weight = weight;
        }

        public void SetVerticalSize(int verticalSize) {
            this.verticalSize = verticalSize;
        }
    }
}
