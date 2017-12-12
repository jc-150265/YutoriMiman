using System;
using System.Collections.Generic;
using SQLite;

namespace test10
{
    [Table("Book")]
    public class InfoFromRakuten
    {
        [PrimaryKey,AutoIncrement]
        public int isbn { get; set; }

        public string title { get; set; }

        public string titleKana { get; set; }

        public string subTitle { get; set; }

        public string subTitleKana { get; set; }

        public string seriesName { get; set; }

        public string seriesNameKana { get; set; }

        public string contents { get; set; }

        public string author { get; set; }

        public string authorKana { get; set; }

        public string publishName { get; set; }

        public string size { get; set; }

        public string itemCaption { get; set; }

        public string salesDate { get; set; }

        public string itemUrl { get; set; }

        public string smallImageUrl { get; set; }

        public string mediumImageUrl { get; set; }

        public string largeImageUrl { get; set; }

        public string reveiwCount { get; set; }

        public string reviewAverage { get; set; }

        public string booksGenreId { get; set; }

        public static void insert()
        {
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースにUserテーブルを作成する
                    db.CreateTable<UserModel>();

                    db.Insert(new UserModel() { Id = id, Name = name });
                    db.Commit();
                }
                catch (Exception e)
                {
                    db.Rollback();
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }
    }
}
