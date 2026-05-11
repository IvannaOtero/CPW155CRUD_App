using System;
using System.Collections.Generic;
using System.Text;

namespace CPW155CRUD_App;


/// <summary>
/// Represents a single physical tennis racket to sell. 
/// </summary>
public class TennisRacket
{
    public int ItemId {  get; set; }

    /// <summary>
    /// the weights in ounces of the tennis racket
    /// </summary>
    public byte Weight { get; set; }


    /// <summary>
    /// The size of the racket head in centemeters 
    /// </summary>
    public short HeadSize { get; set; } 


    /// <summary>
    ///  the brand name or manufacturer of the tennis racket
    /// </summary>
    public required string Brand { get; set; }

    /// <summary>
    /// the price the racket will sell at retail
    /// </summary>
    public double Price { get; set; }
}
