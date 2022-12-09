# Bibliotek_H1

This program is a project meant to emulate a library which contains a list of loaners and books. Loaners and books can be added.

The program initially creates 3 loaners and 3 books to have something to work with.

A prompt is displayed with a menu where the user must choose one option. After the operation is done the program clears the screen and returns to the menu.

The menu options include:
 * Print the library's name and current date
 * Create a new loaner
 * Print out all the loaners in the current library
 * Print out all the books available in the library
 * Loan a book
 * Close the program
 
 
 # How to use each option
 
 1. Print the library's name and current date
  * Just input 1 in the menu prompt and the library's name and current date will be outputted to the screen.
  
 2. Create a new loaner
  * Input 2 in the menu prompt. Then the program will ask the user to input the loaners name, an email address and an ID for the loaner.
  * The program then adds the loaner to the list of loaners of the library.
  
 3. Print out all the loaners in the current library
  * Input 3 in the menu prompt. The program will clear the screen then iterate through the list of loaners of the library and print their names, email, loaner ID and the library they exist in out to the screen.
  
 4. Print out all the loaners in the current library
  * Input 4 in the menu prompt. The program will clear the screen then iterate through the list of books of the library and print the book title, its author and ISBN out to the screen.
 
 5. Loan a book
  * Input 5 in the menu prompt. The program will first print out all of the available books(same as in opt. 4) 
  * Then the user must input the ISBN of the book they wish to loan. The prompt is cancelled if the ISBN can not be found
  * If the book ISBN is found in the library's book list, the program will ask the user to input a loaner ID in order to loan a book on that loaner ID.
  
 6. Close the program
  * I think this one might terminate the program.
  
