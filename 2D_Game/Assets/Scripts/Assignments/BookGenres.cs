using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookGenres : MonoBehaviour {

	public string books;


	void Start(){

		Books(books);
	}

	void Books(string bookGenre){

		if(bookGenre == "Mystery"){
			print("This book is about detectives!");
		}
		else if(bookGenre == "Romance"){
			print("This is about the drama of two lovers!");
		}
		else if(bookGenre == "Fantasy"){
			print("This book is for nerds!");
		}
		else if(bookGenre == "Action"){
			print("This book involves a lot of matrix references.");
		}
		else if(bookGenre == "Sci-fi"){
			print("this book is about space travel!");
		}
		else if(bookGenre == "Thriller"){
			print("This book will have a lot of suspense!");
		}
		else if(bookGenre == "Tradgedy"){
			print("Most likey written by Shakespeare.");
		}
		else if(bookGenre == "Western"){
			print("Yeehaw.");
		}
		else if(bookGenre == "Non-fiction"){
			print("Probably boring.");
		}
		else if(bookGenre == "Melodrama"){
			print("There will be lots of crying.");
		}
		else{
			print("I don't understand "+ bookGenre);
		}
}
}