function agility() {
    var table = document.getElementById("StatsTable");
    while (table.hasChildNodes()) {
        table.removeChild(table.firstChild);
    }
    document.getElementById('contentDescription').innerHTML = 'Agility is the Character\'s hand-eye coordination, nimbleness and reflexes. This Attribute is best suited to action-oriented characters such as pilots, bodyguards and pickpockets, all of which are likely to have a high Agility ratings';
    var header = table.createTHead();
    var hrow = header.insertRow(0);
    var hcell1 = hrow.insertCell(0);
    var hcell2 = hrow.insertCell(1);
    hcell1.innerHTML = "AGI_Rating";
    hcell2.innerHTML = "Equivalence";

    var body1 = table.createTBody();
    var firstrow = body1.insertRow(0);
    var fcell1 = firstrow.insertCell(0);
    var fcell2 = firstrow.insertCell(1);
    fcell1.innerHTML = "+3";
    fcell2.innerHTML = "Olympic gymnast";
    var secondrow = body1.insertRow(1);
    var scell1 = secondrow.insertCell(0);
    var scell2 = secondrow.insertCell(1);
    scell1.innerHTML = "+2";
    scell2.innerHTML = "Agile";
    var thirdrow = body1.insertRow(2);
    var tcell1 = thirdrow.insertCell(0);
    var tcell2 = thirdrow.insertCell(1);
    tcell1.innerHTML = "+1";
    tcell2.innerHTML = "Well-coordinated";
    var fourthrow = body1.insertRow(3);
    var focell1 = fourthrow.insertCell(0);
    var focell2 = fourthrow.insertCell(1);
    focell1.innerHTML = "0";
    focell2.innerHTML = "Average Person";
    var fifthrow = body1.insertRow(4);
    var ficell1 = fifthrow.insertCell(0);
    var ficell2 = fifthrow.insertCell(1);
    ficell1.innerHTML = "-1";
    ficell2.innerHTML = "Awkward";
    var sixthrow = body1.insertRow(5);
    var sicell1 = sixthrow.insertCell(0);
    var sicell2 = sixthrow.insertCell(1);
    sicell1.innerHTML = "-2";
    sicell2.innerHTML = "Clumsy";
    var seventhrow = body1.insertRow(6);
    var secell1 = seventhrow.insertCell(0);
    var secell2 = seventhrow.insertCell(1);
    secell1.innerHTML = "-3";
    secell2.innerHTML = "Suffers from a crippling disease"
}
function appearance() {
    var table = document.getElementById("StatsTable");
    while (table.hasChildNodes()) {
        table.removeChild(table.firstChild);
    }
    document.getElementById("contentDescription").innerHTML = "Appearance rates the physical attractiveness of the character. This can modify how other people react to him: many heroic characters have a high Appearance rating in order to impress those they come in contact with. Note that Appearance applies solely between members of the same race.";
    var header = table.createTHead();
    var hrow = header.insertRow(0);
    var hcell1 = hrow.insertCell(0);
    var hcell2 = hrow.insertCell(1);
    hcell1.innerHTML = "APP_Rating";
    hcell2.innerHTML = "Equivalence";

    var body1 = table.createTBody();
    var firstrow = body1.insertRow(0);
    var fcell1 = firstrow.insertCell(0);
    var fcell2 = firstrow.insertCell(1);
    fcell1.innerHTML = "+3";
    fcell2.innerHTML = "World-class models";
    var secondrow = body1.insertRow(1);
    var scell1 = secondrow.insertCell(0);
    var scell2 = secondrow.insertCell(1);
    scell1.innerHTML = "+2";
    scell2.innerHTML = "Beautiful";
    var thirdrow = body1.insertRow(2);
    var tcell1 = thirdrow.insertCell(0);
    var tcell2 = thirdrow.insertCell(1);
    tcell1.innerHTML = "+1";
    tcell2.innerHTML = "Attractive, Cute";
    var fourthrow = body1.insertRow(3);
    var focell1 = fourthrow.insertCell(0);
    var focell2 = fourthrow.insertCell(1);
    focell1.innerHTML = "0";
    focell2.innerHTML = "Average Person";
    var fifthrow = body1.insertRow(4);
    var ficell1 = fifthrow.insertCell(0);
    var ficell2 = fifthrow.insertCell(1);
    ficell1.innerHTML = "-1";
    ficell2.innerHTML = "Plain";
    var sixthrow = body1.insertRow(5);
    var sicell1 = sixthrow.insertCell(0);
    var sicell2 = sixthrow.insertCell(1);
    sicell1.innerHTML = "-2";
    sicell2.innerHTML = "Homely";
    var seventhrow = body1.insertRow(6);
    var secell1 = seventhrow.insertCell(0);
    var secell2 = seventhrow.insertCell(1);
    secell1.innerHTML = "-3";
    secell2.innerHTML = "Physically revolting";
}
function build() {
    var table = document.getElementById("StatsTable");
    while (table.hasChildNodes()) {
        table.removeChild(table.firstChild);
    }
    document.getElementById("contentDescription").innerHTML = "Build is a rating of the character\’s size and body frame. It does not represent the character\’s physical might — that’s what\’s the Strength Secondary Attribute is for — but the actual body size and mass. This is most apparent in the archetypal couch potato who is very large (high Build), but can barely lift the remote to change the channel.";
    var header = table.createTHead();
    var hrow = header.insertRow(0);
    var hcell1 = hrow.insertCell(0);
    var hcell2 = hrow.insertCell(1);
    hcell1.innerHTML = "BLD_Rating";
    hcell2.innerHTML = "Equivalence";

    var body1 = table.createTBody();
    var firstrow = body1.insertRow(0);
    var fcell1 = firstrow.insertCell(0);
    var fcell2 = firstrow.insertCell(1);
    fcell1.innerHTML = "+5";
    fcell2.innerHTML = "180-249.9 kg";
    var secondrow = body1.insertRow(1);
    var scell1 = secondrow.insertCell(0);
    var scell2 = secondrow.insertCell(1);
    scell1.innerHTML = "+4";
    scell2.innerHTML = "140-179.9 kg";
    var thirdrow = body1.insertRow(2);
    var tcell1 = thirdrow.insertCell(0);
    var tcell2 = thirdrow.insertCell(1);
    tcell1.innerHTML = "+3";
    tcell2.innerHTML = "115-139.9 kg";
    var fourthrow = body1.insertRow(3);
    var focell1 = fourthrow.insertCell(0);
    var focell2 = fourthrow.insertCell(1);
    focell1.innerHTML = "+2";
    focell2.innerHTML = "95-114.9 kg";
    var fifthrow = body1.insertRow(4);
    var ficell1 = fifthrow.insertCell(0);
    var ficell2 = fifthrow.insertCell(1);
    ficell1.innerHTML = "+1";
    ficell2.innerHTML = "80- 94.9 kg";
    var sixthrow = body1.insertRow(5);
    var sicell1 = sixthrow.insertCell(0);
    var sicell2 = sixthrow.insertCell(1);
    sicell1.innerHTML = "0";
    sicell2.innerHTML = "70-79.9 kg";
    var seventhrow = body1.insertRow(6);
    var secell1 = seventhrow.insertCell(0);
    var secell2 = seventhrow.insertCell(1);
    secell1.innerHTML = "-1";
    secell2.innerHTML = "60-69.9 kg";
    var eightrow = body1.insertRow(7);
    var ecell1 = eightrow.insertCell(0);
    var ecell2 = eightrow.insertCell(1);
    ecell1.innerHTML = "-2";
    ecell2.innerHTML = "50-59.9 kg";
    var ninethrow = body1.insertRow(8);
    var ncell1 = ninethrow.insertCell(0);
    var ncell2 = ninethrow.insertCell(1);
    ncell1.innerHTML = "-3";
    ncell2.innerHTML = "40-49.9 kg";
    var tenthrow = body1.insertRow(9);
    var tcell1 = tenthrow.insertCell(0);
    var tcell2 = tenthrow.insertCell(1);
    tcell1.innerHTML = "-4";
    tcell2.innerHTML = "25-39.9 kg";
    var eleventhrow = body1.insertRow(10);
    var elcell1 = eleventhrow.insertCell(0);
    var elcell2 = eleventhrow.insertCell(1);
    elcell1.innerHTML = "-5";
    elcell2.innerHTML = "10-24.9 kg";
}
function creativity() {
    var table = document.getElementById("StatsTable");
    while (table.hasChildNodes()) {
        table.removeChild(table.firstChild);
    }
    document.getElementById("contentDescription").innerHTML = "Creativity is a measure of the character\’s ability to use his mind in innovative ways. It is also a measure of the character\’s ability to think on his feet. This Attribute is useful for most characters who are likely to be thrust into unfamiliar situations and for leaders who have to make many decisions while on the run.";
    var header = table.createTHead();
    var hrow = header.insertRow(0);
    var hcell1 = hrow.insertCell(0);
    var hcell2 = hrow.insertCell(1);
    hcell1.innerHTML = "CRE_Rating";
    hcell2.innerHTML = "Equivalence";

    var body1 = table.createTBody();
    var firstrow = body1.insertRow(0);
    var fcell1 = firstrow.insertCell(0);
    var fcell2 = firstrow.insertCell(1);
    fcell1.innerHTML = "+3";
    fcell2.innerHTML = "Great Artists and tacticians";
    var secondrow = body1.insertRow(1);
    var scell1 = secondrow.insertCell(0);
    var scell2 = secondrow.insertCell(1);
    scell1.innerHTML = "+2";
    scell2.innerHTML = "Bright";
    var thirdrow = body1.insertRow(2);
    var tcell1 = thirdrow.insertCell(0);
    var tcell2 = thirdrow.insertCell(1);
    tcell1.innerHTML = "+1";
    tcell2.innerHTML = "Witty";
    var fourthrow = body1.insertRow(3);
    var focell1 = fourthrow.insertCell(0);
    var focell2 = fourthrow.insertCell(1);
    focell1.innerHTML = "0";
    focell2.innerHTML = "Average Person";
    var fifthrow = body1.insertRow(4);
    var ficell1 = fifthrow.insertCell(0);
    var ficell2 = fifthrow.insertCell(1);
    ficell1.innerHTML = "-1";
    ficell2.innerHTML = "Slow";
    var sixthrow = body1.insertRow(5);
    var sicell1 = sixthrow.insertCell(0);
    var sicell2 = sixthrow.insertCell(1);
    sicell1.innerHTML = "-2";
    sicell2.innerHTML = "Dumb";
    var seventhrow = body1.insertRow(6);
    var secell1 = seventhrow.insertCell(0);
    var secell2 = seventhrow.insertCell(1);
    secell1.innerHTML = "-3";
    secell2.innerHTML = "Mentally Disabled";
}
function fitness() {
    var table = document.getElementById("StatsTable");
    while (table.hasChildNodes()) {
        table.removeChild(table.firstChild);
    }
    document.getElementById("contentDescription").innerHTML = "Fitness rates the character\’s general flexibility, cardiovascular endurance, resistance to effort and overall muscle tone. While Build measures raw size, Fitness measures how well maintained the character\’s body is. Illness can temporarily reduce this Attribute, as can other hardships (such as a substandard air supply and starvation).";
    var header = table.createTHead();
    var hrow = header.insertRow(0);
    var hcell1 = hrow.insertCell(0);
    var hcell2 = hrow.insertCell(1);
    hcell1.innerHTML = "FIT_Rating";
    hcell2.innerHTML = "Equivalence";

    var body1 = table.createTBody();
    var firstrow = body1.insertRow(0);
    var fcell1 = firstrow.insertCell(0);
    var fcell2 = firstrow.insertCell(1);
    fcell1.innerHTML = "+3";
    fcell2.innerHTML = "Olympic athlete";
    var secondrow = body1.insertRow(1);
    var scell1 = secondrow.insertCell(0);
    var scell2 = secondrow.insertCell(1);
    scell1.innerHTML = "+2";
    scell2.innerHTML = "Professional athlete";
    var thirdrow = body1.insertRow(2);
    var tcell1 = thirdrow.insertCell(0);
    var tcell2 = thirdrow.insertCell(1);
    tcell1.innerHTML = "+1";
    tcell2.innerHTML = "College jock";
    var fourthrow = body1.insertRow(3);
    var focell1 = fourthrow.insertCell(0);
    var focell2 = fourthrow.insertCell(1);
    focell1.innerHTML = "0";
    focell2.innerHTML = "Average Person";
    var fifthrow = body1.insertRow(4);
    var ficell1 = fifthrow.insertCell(0);
    var ficell2 = fifthrow.insertCell(1);
    ficell1.innerHTML = "-1";
    ficell2.innerHTML = "Out of shape";
    var sixthrow = body1.insertRow(5);
    var sicell1 = sixthrow.insertCell(0);
    var sicell2 = sixthrow.insertCell(1);
    sicell1.innerHTML = "-2";
    sicell2.innerHTML = "Shrimp";
    var seventhrow = body1.insertRow(6);
    var secell1 = seventhrow.insertCell(0);
    var secell2 = seventhrow.insertCell(1);
    secell1.innerHTML = "-3";
    secell2.innerHTML = "Gets winded after a few steps";
}
function influence() {
    var table = document.getElementById("StatsTable");
    while (table.hasChildNodes()) {
        table.removeChild(table.firstChild);
    }
    document.getElementById("contentDescription").innerHTML = "Influence measures the character\’s charm, wit and persuasiveness. A high Influence rating is a must for any charismatic leader. It is also useful for those who desire to spend lots of time in corporate or social settings, or characters who need to get past security in more subtle ways.";
    var header = table.createTHead();
    var hrow = header.insertRow(0);
    var hcell1 = hrow.insertCell(0);
    var hcell2 = hrow.insertCell(1);
    hcell1.innerHTML = "INF_Rating";
    hcell2.innerHTML = "Equivalence";

    var body1 = table.createTBody();
    var firstrow = body1.insertRow(0);
    var fcell1 = firstrow.insertCell(0);
    var fcell2 = firstrow.insertCell(1);
    fcell1.innerHTML = "+3";
    fcell2.innerHTML = "Charismatic leader or professional con artist";
    var secondrow = body1.insertRow(1);
    var scell1 = secondrow.insertCell(0);
    var scell2 = secondrow.insertCell(1);
    scell1.innerHTML = "+2";
    scell2.innerHTML = "Believable";
    var thirdrow = body1.insertRow(2);
    var tcell1 = thirdrow.insertCell(0);
    var tcell2 = thirdrow.insertCell(1);
    tcell1.innerHTML = "+1";
    tcell2.innerHTML = "Likeable";
    var fourthrow = body1.insertRow(3);
    var focell1 = fourthrow.insertCell(0);
    var focell2 = fourthrow.insertCell(1);
    focell1.innerHTML = "0";
    focell2.innerHTML = "Average Person";
    var fifthrow = body1.insertRow(4);
    var ficell1 = fifthrow.insertCell(0);
    var ficell2 = fifthrow.insertCell(1);
    ficell1.innerHTML = "-1";
    ficell2.innerHTML = "Timid";
    var sixthrow = body1.insertRow(5);
    var sicell1 = sixthrow.insertCell(0);
    var sicell2 = sixthrow.insertCell(1);
    sicell1.innerHTML = "-2";
    sicell2.innerHTML = "Annoying";
    var seventhrow = body1.insertRow(6);
    var secell1 = seventhrow.insertCell(0);
    var secell2 = seventhrow.insertCell(1);
    secell1.innerHTML = "-3";
    secell2.innerHTML = "Either obnoxious or socially inept";
}
function knowledge() {
    var table = document.getElementById("StatsTable");
    while (table.hasChildNodes()) {
        table.removeChild(table.firstChild);
    }
    document.getElementById("contentDescription").innerHTML = "Knowledge is the character\’s ability to learn and recall information and also takes into account the number of years of education the character has successfully completed. Scientists and “brainiac” characters typically have high Knowledge ratings";
    var header = table.createTHead();
    var hrow = header.insertRow(0);
    var hcell1 = hrow.insertCell(0);
    var hcell2 = hrow.insertCell(1);
    hcell1.innerHTML = "KNO_Rating";
    hcell2.innerHTML = "Equivalence";

    var body1 = table.createTBody();
    var firstrow = body1.insertRow(0);
    var fcell1 = firstrow.insertCell(0);
    var fcell2 = firstrow.insertCell(1);
    fcell1.innerHTML = "+3";
    fcell2.innerHTML = "Eminent Scholar";
    var secondrow = body1.insertRow(1);
    var scell1 = secondrow.insertCell(0);
    var scell2 = secondrow.insertCell(1);
    scell1.innerHTML = "+2";
    scell2.innerHTML = "Well-educated";
    var thirdrow = body1.insertRow(2);
    var tcell1 = thirdrow.insertCell(0);
    var tcell2 = thirdrow.insertCell(1);
    tcell1.innerHTML = "+1";
    tcell2.innerHTML = "Knowledgeable";
    var fourthrow = body1.insertRow(3);
    var focell1 = fourthrow.insertCell(0);
    var focell2 = fourthrow.insertCell(1);
    focell1.innerHTML = "0";
    focell2.innerHTML = "Average Person";
    var fifthrow = body1.insertRow(4);
    var ficell1 = fifthrow.insertCell(0);
    var ficell2 = fifthrow.insertCell(1);
    ficell1.innerHTML = "-1";
    ficell2.innerHTML = "Doesn\'t read much";
    var sixthrow = body1.insertRow(5);
    var sicell1 = sixthrow.insertCell(0);
    var sicell2 = sixthrow.insertCell(1);
    sicell1.innerHTML = "-2";
    sicell2.innerHTML = "Poor education";
    var seventhrow = body1.insertRow(6);
    var secell1 = seventhrow.insertCell(0);
    var secell2 = seventhrow.insertCell(1);
    secell1.innerHTML = "-3";
    secell2.innerHTML = "Learning disability or just dense";
}
function perception() {
    var table = document.getElementById("StatsTable");
    while (table.hasChildNodes()) {
        table.removeChild(table.firstChild);
    }
    document.getElementById("contentDescription").innerHTML = "Perception is a measure of the character\’s attentiveness to detail and overall alertness. It is crucial for action heroes, since the enemy who cannot be seen cannot be dealt with. Perception is especially important for scouts and investigators, who need to pay attention to obscure details and find things hidden from view.";
    var header = table.createTHead();
    var hrow = header.insertRow(0);
    var hcell1 = hrow.insertCell(0);
    var hcell2 = hrow.insertCell(1);
    hcell1.innerHTML = "PER_Rating";
    hcell2.innerHTML = "Equivalence";

    var body1 = table.createTBody();
    var firstrow = body1.insertRow(0);
    var fcell1 = firstrow.insertCell(0);
    var fcell2 = firstrow.insertCell(1);
    fcell1.innerHTML = "+3";
    fcell2.innerHTML = "Amazingly sharp senses";
    var secondrow = body1.insertRow(1);
    var scell1 = secondrow.insertCell(0);
    var scell2 = secondrow.insertCell(1);
    scell1.innerHTML = "+2";
    scell2.innerHTML = "Quick";
    var thirdrow = body1.insertRow(2);
    var tcell1 = thirdrow.insertCell(0);
    var tcell2 = thirdrow.insertCell(1);
    tcell1.innerHTML = "+1";
    tcell2.innerHTML = "Fast";
    var fourthrow = body1.insertRow(3);
    var focell1 = fourthrow.insertCell(0);
    var focell2 = fourthrow.insertCell(1);
    focell1.innerHTML = "0";
    focell2.innerHTML = "Average Person";
    var fifthrow = body1.insertRow(4);
    var ficell1 = fifthrow.insertCell(0);
    var ficell2 = fifthrow.insertCell(1);
    ficell1.innerHTML = "-1";
    ficell2.innerHTML = "Slow";
    var sixthrow = body1.insertRow(5);
    var sicell1 = sixthrow.insertCell(0);
    var sicell2 = sixthrow.insertCell(1);
    sicell1.innerHTML = "-2";
    sicell2.innerHTML = "Absent-minded";
    var seventhrow = body1.insertRow(6);
    var secell1 = seventhrow.insertCell(0);
    var secell2 = seventhrow.insertCell(1);
    secell1.innerHTML = "-3";
    secell2.innerHTML = "Unaware of his surrounding";
}
function psyche() {
    var table = document.getElementById("StatsTable");
    while (table.hasChildNodes()) {
        table.removeChild(table.firstChild);
    }
    document.getElementById("contentDescription").innerHTML = "Psyche is an abstract measure of the character\’s karma, happiness, sensitivity and love of life. It also reflects the empathy of the character and how “in tune” he is with his own emotions and those of others, as well as his innate luck. Psyche is an abstract concept which is best reflected by extremes; someone with a low psyche seems to have a black cloud over his head all the time and people will intuitively avoid him. A person with a high Psyche is empathic towards the feelings of others and tends to be easily trusted.";
    var header = table.createTHead();
    var hrow = header.insertRow(0);
    var hcell1 = hrow.insertCell(0);
    var hcell2 = hrow.insertCell(1);
    hcell1.innerHTML = "PSY_Rating";
    hcell2.innerHTML = "Equivalence";

    var body1 = table.createTBody();
    var firstrow = body1.insertRow(0);
    var fcell1 = firstrow.insertCell(0);
    var fcell2 = firstrow.insertCell(1);
    fcell1.innerHTML = "+3";
    fcell2.innerHTML = "Unusually spry and sane";
    var secondrow = body1.insertRow(1);
    var scell1 = secondrow.insertCell(0);
    var scell2 = secondrow.insertCell(1);
    scell1.innerHTML = "+2";
    scell2.innerHTML = "Very Happy";
    var thirdrow = body1.insertRow(2);
    var tcell1 = thirdrow.insertCell(0);
    var tcell2 = thirdrow.insertCell(1);
    tcell1.innerHTML = "+1";
    tcell2.innerHTML = "Happy";
    var fourthrow = body1.insertRow(3);
    var focell1 = fourthrow.insertCell(0);
    var focell2 = fourthrow.insertCell(1);
    focell1.innerHTML = "0";
    focell2.innerHTML = "Average Person";
    var fifthrow = body1.insertRow(4);
    var ficell1 = fifthrow.insertCell(0);
    var ficell2 = fifthrow.insertCell(1);
    ficell1.innerHTML = "-1";
    ficell2.innerHTML = "Unhappy";
    var sixthrow = body1.insertRow(5);
    var sicell1 = sixthrow.insertCell(0);
    var sicell2 = sixthrow.insertCell(1);
    sicell1.innerHTML = "-2";
    sicell2.innerHTML = "Troubled";
    var seventhrow = body1.insertRow(6);
    var secell1 = seventhrow.insertCell(0);
    var secell2 = seventhrow.insertCell(1);
    secell1.innerHTML = "-3";
    secell2.innerHTML = "Unstable";
}
function willpower() {
    var table = document.getElementById("StatsTable");
    while (table.hasChildNodes()) {
        table.removeChild(table.firstChild);
    }
    document.getElementById("contentDescription").innerHTML = "Willpower is a rating of the character\’s selfdiscipline, determination and pain threshold. Unlike Psyche, Willpower does not imply a love of life; it does however reflect the character\’s ability to deny death using sheer strength of will. Headstrong and arrogant characters are good candidates for a high WIL, as are shocktroopers who want to be able to take a bullet.";
    var header = table.createTHead();
    var hrow = header.insertRow(0);
    var hcell1 = hrow.insertCell(0);
    var hcell2 = hrow.insertCell(1);
    hcell1.innerHTML = "WIL_Rating";
    hcell2.innerHTML = "Equivalence";

    var body1 = table.createTBody();
    var firstrow = body1.insertRow(0);
    var fcell1 = firstrow.insertCell(0);
    var fcell2 = firstrow.insertCell(1);
    fcell1.innerHTML = "+3";
    fcell2.innerHTML = "Can endure weeks of torture without cracking";
    var secondrow = body1.insertRow(1);
    var scell1 = secondrow.insertCell(0);
    var scell2 = secondrow.insertCell(1);
    scell1.innerHTML = "+2";
    scell2.innerHTML = "Strong willed";
    var thirdrow = body1.insertRow(2);
    var tcell1 = thirdrow.insertCell(0);
    var tcell2 = thirdrow.insertCell(1);
    tcell1.innerHTML = "+1";
    tcell2.innerHTML = "Willful";
    var fourthrow = body1.insertRow(3);
    var focell1 = fourthrow.insertCell(0);
    var focell2 = fourthrow.insertCell(1);
    focell1.innerHTML = "0";
    focell2.innerHTML = "Average Person";
    var fifthrow = body1.insertRow(4);
    var ficell1 = fifthrow.insertCell(0);
    var ficell2 = fifthrow.insertCell(1);
    ficell1.innerHTML = "-1";
    ficell2.innerHTML = "Easily Swayed";
    var sixthrow = body1.insertRow(5);
    var sicell1 = sixthrow.insertCell(0);
    var sicell2 = sixthrow.insertCell(1);
    sicell1.innerHTML = "-2";
    sicell2.innerHTML = "Weak Resolve";
    var seventhrow = body1.insertRow(6);
    var secell1 = seventhrow.insertCell(0);
    var secell2 = seventhrow.insertCell(1);
    secell1.innerHTML = "-3";
    secell2.innerHTML = "Cannot stay on a diet longer than five minutes";
}

// Secondary Stats

function strength() {
    var table = document.getElementById("secondStatsTable");
    while (table.hasChildNodes()) {
        table.removeChild(table.firstChild);
    }
    document.getElementById("secondaryDescription").innerHTML = "Strength is a measure of a character\’s raw physical power and brute strength; it is a zeroaverage rating. Strength is the average of Build and Fitness, rounded towards zero. Crossindexing with the Build mass table (section 2.1.1) shows the maximum weight that can be deadlifted and carried a few paces — the lowest weight value in the corresponding entry is used. Thus, a character with a +2 Strength can heft around 95 kg and stagger for a few steps before running into difficulty. A mass equal to half the deadlift capacity can be held above the head and a mass double the deadlift capacity can be dragged along.";
    var header = table.createTHead();
    var hrow = header.insertRow(0);
    var hcell1 = hrow.insertCell(0);
    var hcell2 = hrow.insertCell(1);
    hcell1.innerHTML = "STR_Rating";
    hcell2.innerHTML = "Equivalence";

    var body1 = table.createTBody();
    var firstrow = body1.insertRow(0);
    var fcell1 = firstrow.insertCell(0);
    var fcell2 = firstrow.insertCell(1);
    fcell1.innerHTML = "+3";
    fcell2.innerHTML = "Weightlifter";
    var secondrow = body1.insertRow(1);
    var scell1 = secondrow.insertCell(0);
    var scell2 = secondrow.insertCell(1);
    scell1.innerHTML = "+2";
    scell2.innerHTML = "Professional wrestler";
    var thirdrow = body1.insertRow(2);
    var tcell1 = thirdrow.insertCell(0);
    var tcell2 = thirdrow.insertCell(1);
    tcell1.innerHTML = "+1";
    tcell2.innerHTML = "College Jock";
    var fourthrow = body1.insertRow(3);
    var focell1 = fourthrow.insertCell(0);
    var focell2 = fourthrow.insertCell(1);
    focell1.innerHTML = "0";
    focell2.innerHTML = "Average Person";
    var fifthrow = body1.insertRow(4);
    var ficell1 = fifthrow.insertCell(0);
    var ficell2 = fifthrow.insertCell(1);
    ficell1.innerHTML = "-1";
    ficell2.innerHTML = "Out of shape";
    var sixthrow = body1.insertRow(5);
    var sicell1 = sixthrow.insertCell(0);
    var sicell2 = sixthrow.insertCell(1);
    sicell1.innerHTML = "-2";
    sicell2.innerHTML = "Shrimp";
    var seventhrow = body1.insertRow(6);
    var secell1 = seventhrow.insertCell(0);
    var secell2 = seventhrow.insertCell(1);
    secell1.innerHTML = "-3";
    secell2.innerHTML = "Weakling";
}
function health() {
    var table = document.getElementById("secondStatsTable");
    while (table.hasChildNodes()) {
        table.removeChild(table.firstChild);
    }
    document.getElementById("secondaryDescription").innerHTML = "Health rates a character\’s resistance to illness, toxins and physiological shock; it is a zeroaverage rating. Health is the average of Fitness, Psyche and Willpower, rounded to the nearest whole number. People who never seem to get sick and those who can drink large quantities of alcoholic beverages have a high HEA rating.";
    var header = table.createTHead();
    var hrow = header.insertRow(0);
    var hcell1 = hrow.insertCell(0);
    var hcell2 = hrow.insertCell(1);
    hcell1.innerHTML = "HEA_Rating";
    hcell2.innerHTML = "Equivalence";

    var body1 = table.createTBody();
    var firstrow = body1.insertRow(0);
    var fcell1 = firstrow.insertCell(0);
    var fcell2 = firstrow.insertCell(1);
    fcell1.innerHTML = "+3";
    fcell2.innerHTML = "Never gets a cold";
    var secondrow = body1.insertRow(1);
    var scell1 = secondrow.insertCell(0);
    var scell2 = secondrow.insertCell(1);
    scell1.innerHTML = "+2";
    scell2.innerHTML = "Great Health";
    var thirdrow = body1.insertRow(2);
    var tcell1 = thirdrow.insertCell(0);
    var tcell2 = thirdrow.insertCell(1);
    tcell1.innerHTML = "+1";
    tcell2.innerHTML = "Good Health";
    var fourthrow = body1.insertRow(3);
    var focell1 = fourthrow.insertCell(0);
    var focell2 = fourthrow.insertCell(1);
    focell1.innerHTML = "0";
    focell2.innerHTML = "Average Person";
    var fifthrow = body1.insertRow(4);
    var ficell1 = fifthrow.insertCell(0);
    var ficell2 = fifthrow.insertCell(1);
    ficell1.innerHTML = "-1";
    ficell2.innerHTML = "Weak Health";
    var sixthrow = body1.insertRow(5);
    var sicell1 = sixthrow.insertCell(0);
    var sicell2 = sixthrow.insertCell(1);
    sicell1.innerHTML = "-2";
    sicell2.innerHTML = "Poor health";
    var seventhrow = body1.insertRow(6);
    var secell1 = seventhrow.insertCell(0);
    var secell2 = seventhrow.insertCell(1);
    secell1.innerHTML = "-3";
    secell2.innerHTML = "Perpetually ill";
}
function stamina() {
    var table = document.getElementById("secondStatsTable");
    while (table.hasChildNodes()) {
        table.removeChild(table.firstChild);
    }
    document.getElementById("secondaryDescription").innerHTML = "Stamina is a rating of how much sheer physical punishment a character\’s body can tolerate. Unlike many other Attributes, Stamina is not a zero-average rating: it is equal to five times the total of Build and Health, plus 25. No character may have a Stamina lower than 1 (if lower, round up to one). While a high Stamina will decrease the chances of injury, it is still quite easy for a character to be wounded by gunfire or other deadly weapons. Stamina will be used to work out the Wound Thresholds, which determine when and if a character gets hurt (see sections 2.3.3 and 3.5).";
    var header = table.createTHead();
    var hrow = header.insertRow(0);
    var hcell1 = hrow.insertCell(0);
    var hcell2 = hrow.insertCell(1);
    hcell1.innerHTML = "STA_Rating";
    hcell2.innerHTML = "Equivalence";

    var body1 = table.createTBody();
    var firstrow = body1.insertRow(0);
    var fcell1 = firstrow.insertCell(0);
    var fcell2 = firstrow.insertCell(1);
    fcell1.innerHTML = "10";
    fcell2.innerHTML = "Frail old grandmother, child";
    var secondrow = body1.insertRow(1);
    var scell1 = secondrow.insertCell(0);
    var scell2 = secondrow.insertCell(1);
    scell1.innerHTML = "15";
    scell2.innerHTML = "Young teenager";
    var thirdrow = body1.insertRow(2);
    var tcell1 = thirdrow.insertCell(0);
    var tcell2 = thirdrow.insertCell(1);
    tcell1.innerHTML = "20";
    tcell2.innerHTML = "Weak adult";
    var fourthrow = body1.insertRow(3);
    var focell1 = fourthrow.insertCell(0);
    var focell2 = fourthrow.insertCell(1);
    focell1.innerHTML = "25";
    focell2.innerHTML = "Average individual";
    var fifthrow = body1.insertRow(4);
    var ficell1 = fifthrow.insertCell(0);
    var ficell2 = fifthrow.insertCell(1);
    ficell1.innerHTML = "30";
    ficell2.innerHTML = "Fitness enthusiast";
    var sixthrow = body1.insertRow(5);
    var sicell1 = sixthrow.insertCell(0);
    var sicell2 = sixthrow.insertCell(1);
    sicell1.innerHTML = "40";
    sicell2.innerHTML = "Professional athlete";
    var seventhrow = body1.insertRow(6);
    var secell1 = seventhrow.insertCell(0);
    var secell2 = seventhrow.insertCell(1);
    secell1.innerHTML = "50";
    secell2.innerHTML = "Professional boxer";
}
function unarmedDamage() {
    var table = document.getElementById("secondStatsTable");
    while (table.hasChildNodes()) {
        table.removeChild(table.firstChild);
    }
    document.getElementById("secondaryDescription").innerHTML = "Unarmed damage is the Damage Multiplier of any unarmed (Hand-to-hand Skill) attacks performed by the character. It is not a zero-average rating: Unarmed Damage is equal to three plus the total of Hand-to-hand Skill level, Strength and Build. The minimum Unarmed Damage rating is 1. This damage is on the Personal Scale, not the Vehicle Scale (see section 4.4). The Damage Multiplier is a reflection of both how much force a character can put behind a punch and how well the character can place the blow.";
    var header = table.createTHead();
    var hrow = header.insertRow(0);
    var hcell1 = hrow.insertCell(0);
    var hcell2 = hrow.insertCell(1);
    hcell1.innerHTML = "UD_Rating";
    hcell2.innerHTML = "Equivalence";

    var body1 = table.createTBody();
    var firstrow = body1.insertRow(0);
    var fcell1 = firstrow.insertCell(0);
    var fcell2 = firstrow.insertCell(1);
    fcell1.innerHTML = "1";
    fcell2.innerHTML = "Small Child";
    var secondrow = body1.insertRow(1);
    var scell1 = secondrow.insertCell(0);
    var scell2 = secondrow.insertCell(1);
    scell1.innerHTML = "3";
    scell2.innerHTML = "Average adult";
    var thirdrow = body1.insertRow(2);
    var tcell1 = thirdrow.insertCell(0);
    var tcell2 = thirdrow.insertCell(1);
    tcell1.innerHTML = "5";
    tcell2.innerHTML = "Brawler";
    var fourthrow = body1.insertRow(3);
    var focell1 = fourthrow.insertCell(0);
    var focell2 = fourthrow.insertCell(1);
    focell1.innerHTML = "8";
    focell2.innerHTML = "Martial Artist";
}
function armedDamage() {
    var table = document.getElementById("secondStatsTable");
    while (table.hasChildNodes()) {
        table.removeChild(table.firstChild);
    }
    document.getElementById("secondaryDescription").innerHTML = "Armed Damage is the base Damage Multiplier of any of the character’s armed attacks (Melee Skill). It is not a zero-average rating: Armed Damage is equal to three plus the total of Melee Skill level, Strength and Build. The minimum Armed Damage rating is 1. The Damage Multiplier of a melee weapon is equal to the character’s Armed Damage rating and the weapon’s own base DM. This damage is on the Personal Scale, not the Vehicle Scale (see section 4.4).";
    var header = table.createTHead();
    var hrow = header.insertRow(0);
    var hcell1 = hrow.insertCell(0);
    var hcell2 = hrow.insertCell(1);
    hcell1.innerHTML = "AD_Rating";
    hcell2.innerHTML = "Equivalence";

    var body1 = table.createTBody();
    var firstrow = body1.insertRow(0);
    var fcell1 = firstrow.insertCell(0);
    var fcell2 = firstrow.insertCell(1);
    fcell1.innerHTML = "1";
    fcell2.innerHTML = "Small Child";
    var secondrow = body1.insertRow(1);
    var scell1 = secondrow.insertCell(0);
    var scell2 = secondrow.insertCell(1);
    scell1.innerHTML = "3";
    scell2.innerHTML = "Average adult";
    var thirdrow = body1.insertRow(2);
    var tcell1 = thirdrow.insertCell(0);
    var tcell2 = thirdrow.insertCell(1);
    tcell1.innerHTML = "5";
    tcell2.innerHTML = "Street Thug";
    var fourthrow = body1.insertRow(3);
    var focell1 = fourthrow.insertCell(0);
    var focell2 = fourthrow.insertCell(1);
    focell1.innerHTML = "8";
    focell2.innerHTML = "Skilled swordman";

}
function injury() {
    var table = document.getElementById("secondStatsTable");
    while (table.hasChildNodes()) {
        table.removeChild(table.firstChild);
    }
    document.getElementById("secondaryDescription").innerHTML = "Each level of injury has an associated wounding Threshold. Wound Thresholds are the amount of damage an attack must cause to produce a certain type of wound. An attack produces the type of injury whose Wound Threshold is equal to or under the amount of damage inflicted by the attack; only the most severe of the possible results is applied. For example, if an attack does 40 points of damage to an average individual (whose Wound Thresholds are Flesh Wound = 13, Deep Wound = 25, Instant Death = 50), the attack victim suffers a Deep Wound (40 is greater than the Deep Wound score “25” but is less than the Instant Death score “50”).";
}

function systemShock() {
    var table = document.getElementById("secondStatsTable");
    while (table.hasChildNodes()) {
        table.removeChild(table.firstChild);
    }
    document.getElementById("secondaryDescription").innerHTML = "The System Shock rating is a measure of how many injuries a character can take before going into shock and dying. If the total of System Shock and a character\’s woundinduced action penalties equals zero or less, the character goes into shock (see Injuries, section 3.5). System shock is equal to five plus the character\’s Health. System Shock cannot be lower than one. System Shock is shown on the character sheet as a row of boxes — unused boxes are simply crossed out. As wounds are taken, boxes can be crossed out according to action penalties, representing the damage. See Injuries, section 3.5, for more details on bruises, wounds and their game effects.";
}