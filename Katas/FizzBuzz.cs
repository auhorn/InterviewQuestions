using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas {
  public class FizzBuzz {


    /// <summary>
    /// Any number divisible by three is replaced by the word fizz and any divisible by 
    /// five by the word buzz. Numbers divisible by both become fizzbuzz. A player
    /// who makes a mistake has to take a drink.
    /// Einstein will choose a random number to start with – for example: 4, buzz, fizz, 7, 8, fizz, buzz, 11, fizz, 13, 14, fizzbuzz…
    /// http://codingkata.net/Katas/Beginner/FizzBuzz
    /// </summary>
    /// <param name="i">input number see summary</param>
    /// <returns>calculated answer see summary</returns>
    public string Answer( int i ) {
      if (i < 1) { throw new ArgumentOutOfRangeException( "i", "value must be larger than 0." ); }
      string _answer = string.Empty;
      if (i % 3 == 0) { _answer = "fizz"; }
      if (i % 5 == 0) { _answer += "buzz"; }
      if(string.IsNullOrEmpty( _answer )) { _answer = i.ToString(); }
      return _answer;
    }


    /// <summary>
    /// Any number divisible by three is replaced by the word fizz and any divisible by 
    /// five by the word buzz. Numbers divisible by both become fizzbuzz. A player
    /// who makes a mistake has to take a drink.
    /// Einstein will choose a random number to start with – for example: 4, buzz, fizz, 7, 8, fizz, buzz, 11, fizz, 13, 14, fizzbuzz…
    /// http://codingkata.net/Katas/Beginner/FizzBuzz
    /// </summary>
    /// <param name="listofNumbers">list of numbers as input parameter</param>
    /// <returns>List of numbers and answers</returns>
    public IEnumerable<Tuple<int, string>> Answers( IEnumerable<int> listofNumbers ) {

      foreach (var number in listofNumbers) {
        yield return Tuple.Create(number, Answer( number ));
      }

    }

  }
}
