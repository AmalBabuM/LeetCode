public class Solution {
    public int AreaOfMaxDiagonal(int[][] dimensions) {
        int maxDiagonalSq = 0; // largest diagonal squared so far
        int maxArea = 0;       // area corresponding to the best diagonal

        foreach (var rect in dimensions) {
            int l = rect[0];
            int w = rect[1];

            int diagonalSq = l * l + w * w; // diagonal squared
            int area = l * w;               // area of rectangle

            if (diagonalSq > maxDiagonalSq) {
                // found strictly larger diagonal
                maxDiagonalSq = diagonalSq;
                maxArea = area;
            } else if (diagonalSq == maxDiagonalSq) {
                // diagonals equal → choose rectangle with larger area
                if (area > maxArea) {
                    maxArea = area;
                }
            }
        }

        return maxArea;
    }
}