using Newtonsoft.Json;
using System.IO;
using System;
using UnityEngine;
namespace SaveSystem
{
    public class SaveParametresToJson
    {
        private const string fileName = "PlayerData.json";
        // Start is called before the first frame update
        public void Save(PlayerData persons)
        {
            string json = JsonConvert.SerializeObject(persons, Formatting.Indented);
            string filePath = Path.Combine(Application.dataPath, fileName);
            File.WriteAllText(filePath, json);
            string time = DateTime.Now.ToString("HH:mm");
            UnityEngine.Debug.Log($"Автоматическое сохранение прошло в {time}");
        }
        public PlayerData Load()
        {
            string filePath = Path.Combine(Application.dataPath, fileName);
            Debug.Log(filePath);
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                var persons = JsonConvert.DeserializeObject<PlayerData>(jsonData);
                if (persons == null)
                {
                    persons = new PlayerData();
                }
                return persons;
            }

            Console.WriteLine("Данные не найдены");
            return new PlayerData();
        }
    }
}