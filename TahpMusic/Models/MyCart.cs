using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace TahpMusic.Models
{
    public class MyCart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();
        public virtual void AddItem(Music music, int quantity)
        {
            CartLine line = Lines
            .Where(b => b.Music.MusicID == music.MusicID)
            .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Music = music,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public virtual void RemoveLine(Music music) =>
        Lines.RemoveAll(l => l.Music.MusicID == music.MusicID);
        public decimal ComputeTotalValue() =>
        Lines.Sum(e => e.Music.Gia * e.Quantity);
        public virtual void Clear() => Lines.Clear();
    }
    public class CartLine
    {
        public int CartLineID { get; set; }
        public Music Music { get; set; }
        public int Quantity { get; set; }
    }
}

