using Swan_geese.SubClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swan_geese
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent man = new Parent("Мужик", "Мужской", 52);
            Parent woman = new Parent("Баба", "Женский", 44);
            Child daughter = new Child("Доченька", "Женский", 12);
            Child son = new Child("Сынок", "Мужской", 8);
            Goose goose = new Goose("Гуси-лебеди", "Птица", "Коричневые", 1, 1, 2);
            Oven oven = new Oven("Печка", "Еда");
            AppleTree apple_tree = new AppleTree("Яблоня", "Фрукты", 21);
            MilkRiver milk_river = new MilkRiver("Молочная река", 100, 21);
            GrandParent granny_yaga = new GrandParent("Баба-Яга", "Женский", 119);
            Mouse mouse = new Mouse("Мышка", "Грызун", "Серый", 1, 1, 4);

            Swan_geese_story(man, woman, daughter, son, goose, oven, apple_tree, milk_river, granny_yaga, mouse);
            //правильная концвока при 2, 2, 2, 2, 1, 1, 1, 1 включая рандомы

            Console.ReadKey();
        }

        public static void Swan_geese_story(Parent parent1, Parent parent2, Child child1, Child child2, Goose goose, Oven oven,
            AppleTree appleTree, MilkRiver milkRiver, GrandParent grandParent, Mouse mouse)
        {
            Random rnd = new Random();

            parent1.Keep_live();
            parent2.Ask(child1);
            parent1.Go_out_from_home();

            Console.WriteLine("  Остаться и поиграть с братиком/Пойти гулять? Введите 1 или 2...");

            string number1 = Console.ReadLine();
            if (number1 == "1")
            {
                child1.Stay_at_home();
            }
            else
            {
                child1.Forget();
                child1.Go_out_from_home();
                goose.Steal_child();
                child1.Cry();
                child1.Search();
                child1.Run();
                oven.Keep_staying();
                child1.Where_brother();
                oven.Eat_my_cake();

                Console.WriteLine("  Скушать пирожок/Пойти дальше? Введите 1 или 2...");

                string number2 = Console.ReadLine();
                if (number2 == "1")
                {
                    try
                    {
                        child1.Eat_cake();
                    }
                    catch(NullReferenceException)
                    {
                        Console.WriteLine("Потерялась в лесу.");
                    }
                    finally
                    {

                        child1.Come_to_hut();
                    }
                    child1.Do("-Девочка зашла в дом, говорит");
                    child1.Say("-Здравствуй бабушка!");
                    grandParent.Say("-Здравствуй, девица! Зачем на глаза явилась?");
                    child1.Say("-Я по мхам, по болотам ходила, платье измочила, пришла погреться.");
                    grandParent.Say("Садись покуда кудель прясть.");
                    grandParent.Give_spin(grandParent);
                    child1.Spin();
                    mouse.Run();
                    mouse.Ask_to_eat();
                    child1.Give_to_eat();
                    mouse.Ask_to_run();

                    Console.WriteLine("  Забрать братика и сбежать/Не поверить мышке и ждать бабулю? Введите 1 или 2...");

                    int c = rnd.Next(1, 2);
                    if (c == 1)
                    {
                        child1.Say("-Спасибо тебе большое, мышка!");
                        child1.Go_out_from_hut();
                        grandParent.Ask_girl(grandParent);
                        mouse.Lie();
                        grandParent.Come_to_hut(grandParent);
                        child1.Ask_oven(oven);
                        oven.Save_children();
                        goose.Not_see();
                        child1.Come_to_home();
                        parent1.Come_to_home();
                    }
                    else
                    {
                        child1.Stay_at_hut();
                    }
                }
                else
                {
                    child1.Not_eat_cake();
                    oven.Go_out_child();
                    appleTree.Keep_staying();
                    child1.Where_brother();
                    appleTree.Eat_my_apple();

                    Console.WriteLine("  Не хочу/С радостью! Введите 1 или 2...");

                    int h = rnd.Next(1, 2);
                    if (h == 2)
                    {
                        child1.Eat_apple();
                        child1.Come_to_hut();
                        child1.Do("-Девочка зашла в дом, говорит");
                        child1.Say("-Здравствуй бабушка!");
                        grandParent.Say("-Здравствуй, девица! Зачем на глаза явилась?");
                        child1.Say("-Я по мхам, по болотам ходила, платье измочила, пришла погреться.");
                        grandParent.Say("Садись покуда кудель прясть.");
                        grandParent.Give_spin(grandParent);
                        child1.Spin();
                        mouse.Run();
                        mouse.Ask_to_eat();
                        child1.Give_to_eat();
                        mouse.Ask_to_run();
                        Console.WriteLine("  Забрать братика и сбежать/Не поверить мышке и ждать бабулю? Введите 1 или 2...");
                        string c = Console.ReadLine();
                        if (c == "1")
                        {
                            child1.Say("-Спасибо тебе большое, мышка!");
                            child1.Go_out_from_hut();
                            grandParent.Ask_girl(grandParent);
                            mouse.Lie();
                            grandParent.Come_to_hut(grandParent);
                            child1.Ask_apple_tree(appleTree);
                            appleTree.Save_children();
                            goose.Not_see();
                            goose.Fly();
                            oven.Keep_staying();
                            child1.Ask_oven(oven);
                            oven.Eat_my_cake();

                            Console.WriteLine("  Скушать пирожок/Пойти дальше? Введите 1 или 2...");

                            string number3 = Console.ReadLine();
                            if (number3 == "1")
                            {
                                child1.Eat_cake();
                                oven.Save_children();
                                goose.Not_see();
                                appleTree.Keep_staying();
                                child1.Ask_apple_tree(appleTree);
                                appleTree.Save_children();
                                goose.Not_see();
                                child1.Come_to_home();
                                parent1.Come_to_home();
                            }
                            else
                            {
                                child1.Not_eat();
                            }
                        }
                        else
                        {
                            child1.Stay_at_hut();
                        }
                    }
                    else
                    {
                        child1.Not_eat_apple();
                        appleTree.Go_out_child();
                        milkRiver.Keep_staying();
                        child1.Where_brother();
                        milkRiver.Drink_my_kissel();

                        Console.WriteLine("  Попить киселя/Пойти дальше? Введите 1 или 2...");
                        string number4 = Console.ReadLine();
                        if (number4 == "1")
                        {
                            child1.Drink_kissel();
                            child1.Come_to_hut();
                            child1.Do("-Девочка зашла в дом, говорит");
                            child1.Say("-Здравствуй бабушка!");
                            grandParent.Say("-Здравствуй, девица! Зачем на глаза явилась?");
                            child1.Say("-Я по мхам, по болотам ходила, платье измочила, пришла погреться.");
                            grandParent.Say("Садись покуда кудель прясть.");
                            grandParent.Give_spin(grandParent);
                            child1.Spin();
                            mouse.Run();
                            mouse.Ask_to_eat();
                            child1.Give_to_eat();
                            mouse.Ask_to_run();

                            Console.WriteLine("  Забрать братика и сбежать/Не поверить мышке и ждать бабулю? Введите 1 или 2...");

                            int c = rnd.Next(1, 2);
                            if (c == 1)
                            {
                                child1.Say("-Спасибо тебе большое, мышка!");
                                child1.Go_out_from_hut();
                                grandParent.Ask_girl(grandParent);
                                mouse.Lie();
                                grandParent.Come_to_hut(grandParent);
                                child1.Ask_oven(oven);
                                oven.Eat_my_cake();

                                Console.WriteLine("  Скушать пирожок/Пойти дальше? Введите 1 или 2...");

                                string number5 = Console.ReadLine();
                                if (number5 == "1")
                                {
                                    try
                                    {
                                        child1.Eat_cake(); ;
                                    }
                                    catch (NullReferenceException)
                                    {
                                        child1.Not_eat();
                                    }
                                    finally
                                    {
                                        oven.Save_children();
                                    }
                                    goose.Not_see();
                                    appleTree.Keep_staying();
                                    child1.Ask_apple_tree(appleTree);
                                    appleTree.Eat_my_apple();

                                    Console.WriteLine("  Скушать яблочко/Пойти дальше? Введите 1 или 2...");

                                    string number6 = Console.ReadLine();
                                    if (number6 == "1")
                                    {
                                        child1.Eat_apple();
                                        appleTree.Save_children();
                                        goose.Not_see();
                                        milkRiver.Keep_staying();
                                        child1.Ask_river(milkRiver);
                                        milkRiver.Save_children();
                                        goose.Not_see();
                                        child1.Come_to_home();
                                        parent1.Come_to_home();
                                    }
                                    else
                                    {
                                        child1.Not_eat();
                                    }
                                }
                                else
                                {
                                    child1.Not_eat();
                                }

                            }
                            else
                            {
                                child1.Stay_at_hut();
                            }
                        }
                        else
                        {
                            child1.Not_drink_kissel();
                            milkRiver.Go_out_child();
                            child1.Search_in_fields();
                            child1.Come_to_hut();
                            child1.Do("-Девочка зашла в дом, говорит");
                            child1.Say("-Здравствуй бабушка!");
                            grandParent.Say("-Здравствуй, девица! Зачем на глаза явилась?");
                            child1.Say("-Я по мхам, по болотам ходила, платье измочила, пришла погреться.");
                            grandParent.Say("Садись покуда кудель прясть.");
                            grandParent.Give_spin(grandParent);
                            child1.Spin();
                            mouse.Run();
                            mouse.Ask_to_eat();
                            child1.Give_to_eat();
                            mouse.Ask_to_run();

                            Console.WriteLine("  Забрать братика и сбежать/Не поверить мышке и ждать бабулю? Введите 1 или 2...");

                            string c = Console.ReadLine();
                            if (c == "1")
                            {
                                try
                                {
                                    child1.Say("-Спасибо тебе большое, мышка!");
                                }
                                catch when(c == "2")
                                {
                                    child1.Stay_at_hut();
                                }
                                finally
                                {
                                    child1.Go_out_from_hut();
                                }
                                grandParent.Ask_girl(grandParent);
                                mouse.Lie();
                                grandParent.Come_to_hut(grandParent);
                                oven.Keep_staying();
                                child1.Ask_oven(oven);
                                oven.Eat_my_cake();

                                Console.WriteLine("  Скушать пирожок/Пойти дальше?? Введите 1 или 2...");

                                int number5 = rnd.Next(1, 2);
                                if (number5 == 1)
                                {
                                    child1.Eat_cake();
                                    oven.Save_children();
                                    goose.Not_see();
                                    appleTree.Keep_staying();
                                    child1.Ask_apple_tree(appleTree);
                                    appleTree.Eat_my_apple();

                                    Console.WriteLine("  Скушать яблочко/Пойти дальше? Введите 1 или 2...");

                                    string number6 = Console.ReadLine();
                                    if (number6 == "1")
                                    {
                                        try
                                        {
                                            child1.Eat_apple();
                                        }
                                        catch when (number6 == "2")
                                        {
                                            child1.Not_eat();
                                        }
                                        finally
                                        {
                                            appleTree.Save_children();
                                        }
                                        goose.Not_see();
                                        milkRiver.Keep_staying();
                                        child1.Ask_river(milkRiver);
                                        milkRiver.Flowing("речечка");
                                        milkRiver.Drink_my_kissel();

                                        Console.WriteLine("  Попить киселю/Пойти дальше? Введите 1 или 2...");

                                        string number7 = Console.ReadLine();
                                        if (number7 == "1")
                                        {
                                            child1.Drink_kissel();
                                            milkRiver.Save_children();
                                            goose.Not_see();
                                            child1.Come_to_home();
                                            parent1.Come_to_home();
                                        }
                                        else
                                        {
                                            child1.Not_eat();
                                        }
                                    }
                                }
                                else
                                {
                                    child1.Not_eat();
                                }
                            }
                            else
                            {
                                child1.Stay_at_hut();
                            }
                        }
                    }
                }
            }
        }
    }
}

