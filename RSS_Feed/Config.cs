using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace RSS_Feed
{
    [Serializable]
    public class Config
    {
        /// <summary>
        ///     Стандартный путь к конфигурации
        /// </summary>
        private const string Path = "Config.xml";

        /// <summary>
        ///     <para>Регулярное выражение, описывающее URL</para>
        ///     <para>https://regexr.com/3e6m0</para>
        /// </summary>
        private static readonly Regex UrlRegex =
            new Regex(
                @"(http(s)?:\/\/.)?(www\.)?[-a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)");

        /// <summary>
        ///     Список лент
        /// </summary>
        public List<string> Feeds;

        /// <summary>
        ///     Частота обновления ленты (в минутах)
        /// </summary>
        public int ReloadTimeInMinutes;

        /// <summary>
        ///     Режим отображения (HTML или plain text)
        /// </summary>
        public bool RenderHtml;

        /// <summary>
        ///     Стандартная конфигурация (HTML, обновлять каждые три минуты, Хабр)
        /// </summary>
        public Config()
        {
            Feeds = new List<string>();
            ReloadTimeInMinutes = 3;
            Feeds.Add("https://habr.com/rss/interesting");
            RenderHtml = true;
        }

        /// <summary>
        ///     Добавить ленту
        /// </summary>
        /// <param name="url"></param>
        /// <returns>
        ///     <para>true - лента добавлена</para>
        ///     <para>false - такая лента уже есть в списке</para>
        /// </returns>
        /// <exception cref="ArgumentException">Строка не является url</exception>
        public bool AddFeed(string url)
        {
            if (Feeds.Contains(url))
                return false;

            if (UrlRegex.IsMatch(url))
            {
                Feeds.Add(url);
                return true;
            }

            throw new ArgumentException("Data is not a url");
        }

        /// <summary>
        ///     Загрузить конфигурацию из файла
        /// </summary>
        /// <param name="path">Путь до конфигурации</param>
        /// <returns>Загруженная конфигурация</returns>
        /// <exception cref="IOException"></exception>
        /// <exception cref="UnauthorizedAccessException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="PathTooLongException"></exception>
        /// <exception cref="DirectoryNotFoundException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="System.Security.SecurityException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        public static Config Load(string path = Path)
        {
            var xml = new XmlSerializer(typeof(Config));
            using (var fs = new FileStream(path, FileMode.Open))
            {
                try
                {
                    Config ret = (Config) xml.Deserialize(fs);
                    ret.Feeds = ret.Feeds.Distinct().ToList();
                    return ret;
                }
                catch
                {
                    throw new InvalidCastException("Invalid config data");
                }
            }
        }

        /// <summary>
        ///     Сохранить конфигурацию в XML-файл
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <exception cref="IOException"></exception>
        /// <exception cref="UnauthorizedAccessException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="PathTooLongException"></exception>
        /// <exception cref="DirectoryNotFoundException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="System.Security.SecurityException"></exception>
        public void Save(string path = Path)
        {
            var xml = new XmlSerializer(typeof(Config));
            using (var fs = new FileStream(path, FileMode.Create))
            {
                xml.Serialize(fs, this);
            }
        }

        /// <summary>
        ///     Сохранить стандартную конфигурацию в XML-файл
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <exception cref="IOException"></exception>
        /// <exception cref="UnauthorizedAccessException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="PathTooLongException"></exception>
        /// <exception cref="DirectoryNotFoundException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="System.Security.SecurityException"></exception>
        public static void SaveDefault(string path = Path)
        {
            var def = new Config();
            def.Save(path);
        }
    }
}