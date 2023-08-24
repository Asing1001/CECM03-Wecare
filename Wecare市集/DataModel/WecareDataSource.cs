using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Windows.Data.Json;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

// 這個檔案所定義的資料模型是做為強類型模型的代表範例，
// 選擇的屬性名稱與標準項目範本中的資料繫結一致。
//
// 應用程式可以使用這個模型做為起點，再往上發展，也可以完全捨棄，
// 以適合需要的內容取代。如果使用此模型，您可能可以藉由
// 第一次啟動應用程式時，透過初始化 App.xaml 後置產生之程式碼中載入工作的資料，
// 改善應用程式的回應性。

namespace App3__Win_8._1_.Data
{
    /// <summary>
    /// 通用項目資料模型。
    /// </summary>
    public class Staffs
    {
        public Staffs(String uniqueId, String staffName, String jobTitle, 
            String imagePath, String description, String phoneNumber,
            BitmapImage imageSource, String education, string skill, double score, string comment)
        {
            this.UniqueId = uniqueId;
            this.StaffName = staffName;
            this.JobTitle = jobTitle;
            this.Description = description;
            this.ImagePath = imagePath;
            this.PhoneNumber = phoneNumber;
            this.ImageSource= imageSource;
            this.Education = education;
            this.Skill = skill;
            this.Score = score;
            this.Comment = comment;
        }

        public string UniqueId { get; private set; }
        public string StaffName { get; private set; }
        public string JobTitle { get; private set; }
        public string Description { get; private set; }
        public string ImagePath { get; private set; }
        public string PhoneNumber { get; private set; }
        
        //0903
        public string Education { get; private set; }
        public string Skill { get; private set; }
        public double Score { get; private set; }
        public string Comment { get; private set; }

        public override string ToString()
        {
            return this.StaffName;
        }


        public BitmapImage ImageSource { get; set; }

    }

    /// <summary>
    /// 通用群組資料模型。
    /// </summary>
    public class Divisions
    {
        public Divisions(String uniqueId, String title, String subtitle, String imagePath, String description)
        {
            this.UniqueId = uniqueId;
            this.DivName = title;
            this.Subtitle = subtitle;
            this.Description = description;
            this.ImagePath = imagePath;
            this.Items = new ObservableCollection<Staffs>();
        }

        public string UniqueId { get; private set; }
        public string DivName { get; private set; }
        public string Subtitle { get; private set; }
        public string Description { get; private set; }
        public string ImagePath { get; private set; }
        public ObservableCollection<Staffs> Items { get; private set; }

        public override string ToString()
        {
            return this.DivName;
        }
    }

    /// <summary>
    /// 建立含讀取自靜態 json 檔案之內容的群組和項目集合。
    /// 
    /// SampleDataSource 是以讀取自靜態 json 檔案的資料進行初始化，該等資料係包含在
    /// 專案。 這會在設計階段和執行階段提供範例資料。
    /// </summary>
    public sealed class SampleDataSource
    {
        private static SampleDataSource _sampleDataSource = new SampleDataSource();

        private ObservableCollection<Divisions> _groups = new ObservableCollection<Divisions>();
        public ObservableCollection<Divisions> Groups
        {
            get { return this._groups; }
        }

        public static async Task<IEnumerable<Divisions>> GetGroupsAsync()
        {
            await _sampleDataSource.GetSampleDataAsync();

            return _sampleDataSource.Groups;
        }

        public static async Task<Divisions> GetGroupAsync(string uniqueId)
        {
            await _sampleDataSource.GetSampleDataAsync();
            // 小型資料集可接受簡單線性搜尋
            var matches = _sampleDataSource.Groups.Where((group) => group.UniqueId.Equals(uniqueId));
            if (matches.Count() == 1) return matches.First();
            return null;
        }

        public static async Task<Staffs> GetItemAsync(string uniqueId)
        {
            await _sampleDataSource.GetSampleDataAsync();
            // 小型資料集可接受簡單線性搜尋
            var matches = _sampleDataSource.Groups.SelectMany(group => group.Items).Where((item) => item.UniqueId.Equals(uniqueId));
            if (matches.Count() == 1) return matches.First();
            return null;
        }

        #region imagePathTemp & descriptTemp 暫時用字串
        string imagePathTemp = @"C:\Users\III\Desktop\Solution2 Store AP\App3 (Win 8.1) Demo\Images\german\German_3_600_C.jpg";
        string descriptTemp = @"　　八十三歲的陳珠璋教授，一生經歷台灣精神醫療史；陪台灣的精神病人走過囚禁、電氣痙攣治療、胰島素休克療法、前額葉切除術等過程；沒有他的諄諄教誨，今日的精神醫學界怎能有這麼多的精英？
　　台大榮譽教授陳珠璋會走上精神醫學之路，和他人生的首次挫敗有關。八十三歲的陳珠璋回憶說，恰巧是七十年前的夏日，他報考台北二中落第，在沮喪挫折中，決定苦讀報考台北一中（建中前身），結果居然中榜。1941年6月，陳珠璋初入台北帝大預科，課餘經常與三、五同學在波麗路喝咖啡，行止就如當今的知識青年。陳珠璋表示，他會選擇習醫，是因為青春期驟逢同床共眠的祖父病逝；選擇冷門的精神醫學則是因為師長開導，還有一項巧遇，他首次到精神科蒐集資料時，遇到以後結褵的妻子，更加強他成為精神醫師的意願。1947年日本戰敗，陳珠璋成了改制後的台大醫科首屆畢業生。當時，留守的黑澤良介助教授，將科內職務移交給比陳珠璋高四屆的林宗義。戰後蓽縷的台大神經精神科（編按，之後精神科獨立，再擴大為部）就由林宗義、陳珠璋、林憲等幾位年輕人接手。林宗義曾經回憶，當時的精神科建築只是一間漏水破屋，雨天看診時，護士還要為醫師打傘。林宗義並且感謝陳珠璋的父親出錢、出料義務修繕，精神科才有早期堅固的兩層樓建築。

謙沖、揖讓的前輩
　　在1950年，陳珠璋首次站上講台授課，他形容自己國語、台語、日語、英語、德語夾雜混用，就像一堂「雜菜麵」教學，想來猶覺羞赧。陳珠璋揖讓的性格，可由一事得知。台大醫院是一處排資論輩，尊重「先拜」（編按：前輩的日文發音）的醫療院所。在1965年，林宗義必須赴WHO（世界衛生組織）任職，台大神經精神科主任出缺，那時，晚陳珠璋兩屆的林憲力爭這項職務，在當時台大醫院院長魏火曜一句「大器晚成」的勸勉下，陳珠璋即刻退讓。

嚴格、愛才的長者
    陳珠璋在台大教學以嚴格出名。嘉南療養院院長張達人指出，他在陳教授手下做事時，即使一份自以為很有把握的報告，通過陳教授的手就會被大幅修改；但愈改愈豐富，讓他心服口服。";
#endregion

        private async Task GetSampleDataAsync()
        {
            if (this._groups.Count != 0)
                return;
            ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();
            ObservableCollection<ServiceReference2.MyStaff> Staffs = await client.GetStaffsAsync();

            var q1 = from p in Staffs
                     group p by p.Div;

            //======================
            //(for 套用 格線應用程式 & 做導覽屬性)  
            //SampleDataItem 有 group 屬性
            //SampleDataGroup 有 Items 屬性

            foreach (var group in q1)
            {
                Divisions Division = new Divisions(group.Key.ToString(), group.Key.ToString(), null, null, null);

                foreach (var item in group)
                {
                    Staffs Staff = new Staffs(item.ID.ToString(), item.Name.ToString(), item.Job, imagePathTemp
                        , descriptTemp ,"0"+ item.Tel, await GetImageFromByte(item.Photo)
                        , item.Edu, item.Skill, item.Score,item.NewComment );
                    // Image  Bytes[] 轉成 Image 物件
                   // sampleDataItem.ImageSource = await GetImageFromByte(item.Photo);
                    Division.Items.Add(Staff);
                }

                this.Groups.Add(Division);

            }
        }
        async private static Task<BitmapImage> GetImageFromByte(byte[] img)
        {

            InMemoryRandomAccessStream ras = new InMemoryRandomAccessStream();
            DataWriter dw = new DataWriter(ras.GetOutputStreamAt(0));
            dw.WriteBytes(img);
            await dw.StoreAsync();

            BitmapImage bImg = new BitmapImage();
            bImg.SetSource(ras);
            return bImg;
        }

    }



}
