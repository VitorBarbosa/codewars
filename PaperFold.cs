using System;
using System.Collections.Generic;

public class KataPaperFold {
  public static IEnumerable<int> PaperFold() {
    var folded = new List<int>();
    folded.Add(1);
    var seq = 2;
    do {
      for(var i = 0; i < seq; i++) {
        folded.Insert(i * 2, (i+1) & 1);
      }
      seq *= 2;
    } while (folded.Count <= 100000);
    return folded;
  }
}