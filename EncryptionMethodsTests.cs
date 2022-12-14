using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Encryptor_with_GUI.Tests
{
    [TestClass()]
    public class EncryptionMethodsTests
    {
        [TestMethod()]
        public void EncryptAs1Test()
        {
            //arrange
            string input_string = "testmessage";
            string output_encrypted = "";
            string expected = "84 69 83 84 77 69 83 83 65 71 69";
            List<char> freqsequence_list = new()
            {
                ' ','!','"','#','$','%','&','\'','(',')','*','+',',','-','.','/','0','1','2','3','4','5','6','7','8','9',
                ':',';','<','=','>','?','@','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S',
                'T','U','V','W','X','Y','Z','[','\\',']','^','_','`','a','b','c','d','e','f','g','h','i','j','k','l','m',
                'n','o','p','q','r','s','t','u','v','w','x','y','z','{','|','}','~','А','Б','В','Г','Д','Е','Ж','З','И',
                'Й','К','Л','М','Н','О','П','Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ы','Ь','Э','Ю','Я','а','б','в',
                'г','д','е','ж','з','и','й','к','л','м','н','о','п','р','с','т','у','ф','х','ц','ч','ш','щ','ъ','ы','ь',
                'э','ю','я'
            };

            //action
            MainWindow.EncryptAs1(freqsequence_list, input_string, ref output_encrypted);
            string result = MainWindow.LastSpaceCutter(output_encrypted);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void DecryptAs1Test()
        {
            //arrange
            string input_encrypted = "84 69 83 84 77 69 83 83 65 71 69";
            string expected = "testmessage";
            List<char> freqsequence_list = new()
            {
                ' ','!','"','#','$','%','&','\'','(',')','*','+',',','-','.','/','0','1','2','3','4','5','6','7','8','9',
                ':',';','<','=','>','?','@','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S',
                'T','U','V','W','X','Y','Z','[','\\',']','^','_','`','a','b','c','d','e','f','g','h','i','j','k','l','m',
                'n','o','p','q','r','s','t','u','v','w','x','y','z','{','|','}','~','А','Б','В','Г','Д','Е','Ж','З','И',
                'Й','К','Л','М','Н','О','П','Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ы','Ь','Э','Ю','Я','а','б','в',
                'г','д','е','ж','з','и','й','к','л','м','н','о','п','р','с','т','у','ф','х','ц','ч','ш','щ','ъ','ы','ь',
                'э','ю','я'
            };

            //action
            string result = MainWindow.DecryptAs1(freqsequence_list, input_encrypted);
            
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void FreqSequenceListBuilderTest()
        {
            //arrange
            Dictionary<char, int> input = new()
            {
                {' ', 1},
                {'!', 2},
                {'"', 3},
                {'#', 4}
            };          
            List<char> expected = new()
            {
                ' ',
                '!',
                '"',
                '#'
            };

            //action
            List<char> result = MainWindow.FreqSequenceListBuilder(input);
            
            //assert
            Assert.IsTrue(Enumerable.SequenceEqual(expected, result));
        }

        [TestMethod()]
        public void SymbolRepeat_CounterTest()
        {
            //arrange
            string input = " !!\"\"\"####";
            Dictionary<char, int> expected = new()
            {
                {' ', 1},
                {'!', 2},
                {'"', 3},
                {'#', 4}
            };

            //action
            Dictionary<char, int> result = MainWindow.SymbolRepeatCounter(input);

            //assert
            Assert.IsTrue(Enumerable.SequenceEqual(expected, result));
        }

        [TestMethod()]
        public void AbbcccStringBuilderTest()
        {
            //arrange
            string expected = " !!\"\"\"####$$$$$%%%%%%&&&&&&&''''''''";

            //action
            string abbcccstringbuilder_substr = MainWindow.AbbcccStringBuilder();
            string result = abbcccstringbuilder_substr[..36];
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void EncryptAs2Test()
        {
            //arrange
            string input_string = "testmessage";
            string output_encrypted = "";
            string expected = "0 2 18 0 16 2 18 18 21 25 2";
            List<char> positions_list = new()
            {
                't','h','e','q','u','i','c','k','b','r','o','w','n','f','x','j','m','p','s','v','l','a','z','y','d','g','T','H',
                'E','Q','U','I','C','K','B','R','O','W','N','F','X','J','M','P','S','V','L','A','Z','Y','D','G','с','ъ','е','ш',
                'ь','ж','щ','ё','э','т','и','х','м','я','г','к','ф','р','а','н','ц','у','з','б','л','о','д','в','ы','п','й','ч',
                'ю','С','Ъ','Е','Ш','Ь','Ж','Щ','Ё','Э','Т','И','Х','М','Я','Г','К','Ф','Р','А','Н','Ц','У','З','Б','Л','О','Д',
                'В','Ы','П','Й','Ч','Ю',' ',',','!','.','?','-','_','<','>','[',']','{','}','+','=','$','@','%',':','(',')','"',
                '1','2','3','4','5','6','7','8','9','0'
            };

            //action
            MainWindow.EncryptAs2(positions_list, input_string, ref output_encrypted);
            string result = MainWindow.LastSpaceCutter(output_encrypted);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void DecryptAs2Test()
        {
            //arrange
            string input_encrypted = "0 2 18 0 16 2 18 18 21 25 2";
            string expected = "testmessage";
            List<char> positions_list = new()
            {
                't','h','e','q','u','i','c','k','b','r','o','w','n','f','x','j','m','p','s','v','l','a','z','y','d','g','T','H',
                'E','Q','U','I','C','K','B','R','O','W','N','F','X','J','M','P','S','V','L','A','Z','Y','D','G','с','ъ','е','ш',
                'ь','ж','щ','ё','э','т','и','х','м','я','г','к','ф','р','а','н','ц','у','з','б','л','о','д','в','ы','п','й','ч',
                'ю','С','Ъ','Е','Ш','Ь','Ж','Щ','Ё','Э','Т','И','Х','М','Я','Г','К','Ф','Р','А','Н','Ц','У','З','Б','Л','О','Д',
                'В','Ы','П','Й','Ч','Ю',' ',',','!','.','?','-','_','<','>','[',']','{','}','+','=','$','@','%',':','(',')','"',
                '1','2','3','4','5','6','7','8','9','0'
            };

            //action
            string result = MainWindow.DecryptAs2(positions_list, input_encrypted);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void PositionsListGeneratorTest()
        {
            //arrange
            List<char> expected = new()
            {
                't','h','e','q','u','i','c','k','b','r','o','w','n','f','x','j','m','p','s','v','l','a','z','y','d','g',
                'T','H','E','Q','U','I','C','K','B','R','O','W','N','F','X','J','M','P','S','V','L','A','Z','Y','D','G',
                'с','ъ','е','ш','ь','ж','щ','ё','э','т','и','х','м','я','г','к','ф','р','а','н','ц','у','з','б','л','о','д','в','ы','п','й','ч','ю',
                'С','Ъ','Е','Ш','Ь','Ж','Щ','Ё','Э','Т','И','Х','М','Я','Г','К','Ф','Р','А','Н','Ц','У','З','Б','Л','О','Д','В','Ы','П','Й','Ч','Ю',
                ' ',',','!','.','?','-','_','<','>','[',']','{','}','+','=','$','@','%',':','(',')','"','1','2','3','4','5','6','7','8','9','0'
            };

            //action
            List<char> actual = MainWindow.PositionsListGenerator();

            //assert
            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod()]
        public void EncryptAs3Test()
        {
            //arrange
            string input_string = "testmessage";
            int ascii_shift = 5;
            string seed_string = "!-63-!";
            string expected = "111!-63-!96!-63-!110!-63-!111!-63-!104!-63-!96!-63-!110!-63-!110!-63-!92!-63-!98!-63-!96!-63-!";

            //action
            string result = MainWindow.EncryptAs3(input_string, ascii_shift, seed_string);
            //string result = MainWindow.LastSpaceCutter(output_encrypted);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void DecryptAs3Test()
        {
            //arrange
            string input_encrypted = "111!-63-!96!-63-!110!-63-!111!-63-!104!-63-!96!-63-!110!-63-!110!-63-!92!-63-!98!-63-!96!-63-!";
            int ascii_shift = 5;
            string seed_string = "!-63-!";
            string output_string = "";
            string expected = "testmessage";

            //action
            string result = MainWindow.DecryptAs3(seed_string, output_string, input_encrypted, ascii_shift);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void SeedStringBuilderTest()
        {
            //assert
            char input = 'U';
            string expected = "!-85-!";

            //action
            string actual = MainWindow.SeedStringBuilder(input);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SeedGeneratorTest()
        {
            //arrange
            int expected1 = 33;
            int expexted2 = 125;

            //action
            int actual = MainWindow.SeedGenerator();
            //assert

            //assert
            Assert.IsTrue((actual >= expected1) && (actual <= expexted2));
        }

        [TestMethod()]
        public void UserSeedOutTest()
        {
            //arrange
            int input = 85;
            string expected = "U";

            //action
            string actual = MainWindow.UserSeedOut(input);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void InternalSeedBuilderTest()
        {
            //arrange
            char input = (char)85;
            string expected = "!-85-!";

            //action
            string actual = MainWindow.SeedStringBuilder(input);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PositionsList2GeneratorTest()
        {
            //arrange
            List<char> expected = new()
            {
                'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
                'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                'а','б','в','г','д','е','ё','ж','з','и','й','к','л','м','н','о','п','р','с','т','у','ф','х','ц','ч','ш','щ','ъ','ы','ь','э','ю','я',
                'А','Б','В','Г','Д','Е','Ё','Ж','З','И','Й','К','Л','М','Н','О','П','Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ы','Ь','Э','Ю','Я',
                '1','2','3','4','5','6','7','8','9','0',' ',',','!','.','?','-','_','<','>','[',']','{','}','+','=','$','@','%',':','(',')','"'
            };

            //action
            List<char> actual = MainWindow.PositionsList2Generator();

            //assert
            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod()]
        public void LastSpaceCutterTest()
        {
            //arrange
            string input = "string ";
            string expected = "string";

            //action
            string output = MainWindow.LastSpaceCutter(input);

            //assert
            Assert.AreEqual(expected, output);
        }

    }
}