using NUnit.Framework.Constraints;
using RecentFilesHistory;

namespace RecentFilesHistoryTestProject
{
    [TestFixture]
    public class Tests
    {
        private RecentFilesHistoryManager mgr = new RecentFilesHistoryManager($"{Path.GetTempPath()}/test.json");

        [SetUp]
        public void Setup()
        {
        }


        [Test(Description = "Loading not exisiting json file has to throw exception")]
        public void Test_001_LoadingNoFileThrowsException()
        {
            string path = $"{Path.GetTempPath()}/test.json";
            if ( File.Exists( path ) ) 
                File.Delete( path );

            Assert.That(() => mgr.Load(), Throws.TypeOf<FileNotFoundException>());
        }


        [Test(Description = "Saving an empty collection should not throw any exception")]
        public void Test_002_SavingEmptyFile()
        {
            Assert.DoesNotThrow(() => mgr.Save());
        }


        [Test(Description = "Setting Capacity to zero must throw ArgumentOutOfRangeException")]
        public void Test_003_SetCapacityToZero()
        {
            Assert.That(() => { mgr.Capacity = 0; }, Throws.TypeOf<ArgumentOutOfRangeException>());
        }


        [Test(Description = "Setting Capacity to valid integer should not throw any Exceptions")]
        public void Test_004_SetCapacityTo3()
        {
            Assert.DoesNotThrow(() => { mgr.Capacity = 3; });
        }


        [Test(Description = "Adding File01 to File10.txt: File10.txt must be first, File08.txt must be last, count must be == 3.")]
        public void Test_005_Add_10_Files()
        {
            mgr.PutAtFront("File01.txt");
            mgr.PutAtFront("File02.txt");
            mgr.PutAtFront("File03.txt");
            mgr.PutAtFront("File04.txt");
            mgr.PutAtFront("File05.txt");
            mgr.PutAtFront("File06.txt");
            mgr.PutAtFront("File07.txt");
            mgr.PutAtFront("File08.txt");
            mgr.PutAtFront("File09.txt");
            mgr.PutAtFront("File10.txt");

            Assert.That(mgr.Items.Count, Is.EqualTo(3));
            Assert.That(mgr.Items[0], Is.EqualTo("File10.txt"));
            Assert.That(mgr.Items[mgr.Items.Count - 1], Is.EqualTo("File08.txt"));
        }


        [Test(Description = "Saving 3 items should not throw any Exceptions")]
        public void Test_006_SavingFileWith3Items()
        {
            Assert.DoesNotThrow(() => mgr.Save());
        }


        [Test(Description = "Calling Clear() should not throw any Exceptions and Count must be == 0")]
        public void Test_007_Clear()
        {
            Assert.DoesNotThrow(() => mgr.Clear());
            Assert.That(mgr.Items.Count, Is.EqualTo(0));
        }


        [Test(Description = "Loading again should not throw any exceptions and itmes must have 3 items: first one must be File10.txt, last one: File08.txt")]
        public void Test_008_LoadingFileWith3Items()
        {
            Assert.DoesNotThrow(() => mgr.Load());
            Assert.That(mgr.Items.Count, Is.EqualTo(3));
            Assert.That(mgr.Items[0], Is.EqualTo("File10.txt"));
            Assert.That(mgr.Items[mgr.Items.Count - 1], Is.EqualTo("File08.txt"));
        }

        [Test(Description = "Adding last one: File08.txt must move it to First position and File09.txt must then be at the Last position")]
        public void Test_009_AddLastOneAgain()
        {
            mgr.PutAtFront("File08.txt");
            Assert.That(mgr.Items[0], Is.EqualTo("File08.txt"));
            Assert.That(mgr.Items[mgr.Items.Count - 1], Is.EqualTo("File09.txt"));
        }
    }
}