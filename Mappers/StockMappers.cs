using api.DTOs.Stock;
using api.Models;

namespace api.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock stockModel)
        {
            return new StockDto
            {
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Purchase = stockModel.Purchase,
                LastDiv = stockModel.LastDiv,
                Industry = stockModel.Industry,
                MarketCap = stockModel.MarketCap
            };
        }

        public static Stock ToStockFromCreateDTO(this CreateStockDto createStockDto)
        {
            return new Stock
            {
                Symbol = createStockDto.Symbol,
                CompanyName = createStockDto.CompanyName,
                Purchase = createStockDto.Purchase,
                LastDiv = createStockDto.LastDiv,
                Industry = createStockDto.Industry,
                MarketCap = createStockDto.MarketCap
            };
        }

        public static Stock ToStockFromUpdateDTO(this Stock stockToBeUpdated, UpdateStockDto updateStockDto)
        {
            stockToBeUpdated.CompanyName = updateStockDto.CompanyName;
            stockToBeUpdated.Industry = updateStockDto.Industry;
            stockToBeUpdated.Symbol = updateStockDto.Symbol;
            stockToBeUpdated.CompanyName = updateStockDto.CompanyName;
            stockToBeUpdated.Purchase = updateStockDto.Purchase;
            stockToBeUpdated.LastDiv = updateStockDto.LastDiv;
            stockToBeUpdated.Industry = updateStockDto.Industry;
            stockToBeUpdated.MarketCap = updateStockDto.MarketCap;

            return stockToBeUpdated;
        }
    }
}