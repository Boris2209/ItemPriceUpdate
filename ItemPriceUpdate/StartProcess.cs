using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using ItemPriceUpdate.Model;

namespace ItemPriceUpdate
{
    public class StartProcess
    {
        private Log log;

        public StartProcess(TextBox logTextBox) 
        {
            this.log = new Log(logTextBox);
            log.Add("Запуск сервиса обмена");
            log.Add("Ожидание старта обработки");
        }

        /// <summary>
        /// Начало обработки файла
        /// </summary>
        /// <param name="filePath"></param>
        public void Start(string filePath) 
        {
            log.Add("Старт процесса обработки");

            List<ItemExcelDto> itemList;

            log.Add($"Начало чтения файла {filePath}");

            try
            {
                itemList = GetItemFromExcel(filePath);

                if (itemList == null || itemList.Count == 0)
                {
                    throw new Exception("Не удалось получить данные по товарам");
                }
            }
            catch(Exception ex)
            {
                log.Add($"Ошибка при чтении данных из Excel: {ex.Message}");
                return;
            }

            log.Add($"Получены данные на обновление товаров, всего {itemList.Count} строк");

            log.Add("Тут должна быть логика обработки товаров");
            foreach (var item in itemList) 
            {
                log.Add($"Обработка товара {item.Article} с ценой {item.Price}");
            }

            log.Add($"Конец процесса обработки товаров");

        }

        /// <summary>
        /// Получение списка товаров из Excel
        /// </summary>
        /// <returns></returns>
        public List<ItemExcelDto> GetItemFromExcel(string filePath)
        {
            List<ItemExcelDto> itemList = new List<ItemExcelDto>();

            // Открываем Excel файл
            using (var workbook = new XLWorkbook(filePath))
            {
                // Получаем первый лист (если вам нужно работать с другим листом, укажите индекс)
                var worksheet = workbook.Worksheet(1); // Получаем первый лист (индексация с 1)

                // Начнем с 2-й строки, чтобы пропустить заголовки
                foreach (var row in worksheet.RowsUsed().Skip(1))
                {
                    // Чтение значений из ячеек
                    string article = row.Cell(1).GetValue<string>().Trim(); // Колонка 1 (Артикул)
                    decimal price = row.Cell(2).GetValue<decimal>(); // Колонка 2 (Цена)

                    // Добавляем объект в список
                    itemList.Add(new ItemExcelDto
                    {
                        Article = article,
                        Price = price
                    });
                }
            }

            return itemList;
        }

    }
}
