# Boggle Solver WinForms Application

## Overview
This WinForms application is a Boggle solver that reads a Boggle board configuration and a dictionary of words from text files. It then finds and displays the words that can be formed on the board following Boggle's rules.

## Features
- **Boggle Board:** The application generates a random Boggle board and displays it in a WinForms DataGridView.
- **Dictionary:** Users can open, edit, and save the dictionary of words used for solving Boggle puzzles.
- **Solver:** The solver uses a Trie data structure to efficiently find valid words on the Boggle board, via Depth-First Search(DFS) algorithm.
- **User Interaction:** The user can refresh the Boggle board, choose the number of words to generate(or create a custom dictionary with personalized words), and run the Boggle solver.

## Run the application
1. **Clone the Repository:**
   ```bash
   git clone https://github.com/istentoumis/boggle-solver-winforms.git
   ```
2. Build and run the application.   
