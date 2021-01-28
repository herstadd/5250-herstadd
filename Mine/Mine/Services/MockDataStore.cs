using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mine.Models;

namespace Mine.Services
{
    public class MockDataStore : IDataStore<ItemModel>
    {
        readonly List<ItemModel> items;

        public MockDataStore()
        {
            items = new List<ItemModel>()
            {
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Refrigerator", Description="Heavy item, hits like a piano.", Value=10},
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Calculator", Description="Calculates enemy's weakness and gets them there.", Value = 2},
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Subwoofer", Description="Hits with deep bass, disorienting enemy.", Value = 3},
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Book", Description="'Throws the book' at your enemy", Value = 5 },
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Ninja Troll", Description="Releases dozens of Ninja Trolls", Value = 8 }
            };
        }

        public async Task<bool> CreateAsync(ItemModel item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateAsync(ItemModel item)
        {
            var oldItem = items.Where((ItemModel arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((ItemModel arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<ItemModel> ReadAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<ItemModel>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}