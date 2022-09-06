using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections;
using System.Linq;
using UnityEngine.Video;


namespace Mod
{
    public class Mod : MonoBehaviour
    {
        public static string ModTag = " [FST]"; //Whilst not required, modded items should contain 'tags' at the end of their names to prevent errors in which two mods have an item of the same name.

        public static void Main()
        {


           /*
                    Liquid.Register("Rpg Blood [SNS]", (Liquid)new NovaBloodSNS()); // BlackholeSMPBloodBHS
                    Liquid.Register("Rotton Blood [BHS]", (Liquid)new RottonBloodBHS());
                    Liquid.Register("Mana [SNS]", (Liquid)new manasns());
                    Liquid.Register("Humanoid Blood [SNS]", (Liquid)new HumanoidBloodSNS());
                    Liquid.Register("BlackholeSMP Blood [BHS]", (Liquid)new BlackholeSMPBloodBHS());
                    Liquid.Register("Rotton Void [BHS-SNS]", (Liquid)new RottonVoidBHSSNS());

*/
 Liquid.Register("Golden Blood [FST]", (Liquid)new golddiggerfst()); // BlackholeSMPBloodBHS
                    CategoryBuilder.Create("The Differences", "Includes humans and sub-humans", ModAPI.LoadSprite("Thumb and picture.png"));
 
 
                                  ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Human"), //item to derive from
        NameOverride = "Kazioman [FST]", //new item name with a suffix to assure it is globally unique
        DescriptionOverride = "", //new item description
        CategoryOverride = ModAPI.FindCategory("The Differences"), //new item category
        NameToOrderByOverride = "h",
        ThumbnailOverride = ModAPI.LoadSprite("sprites/view/furryboy.png"), //new item thumbnail (relative path)
        AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
        {
            //load textures for each layer (see Human textures folder in this repository)
            var skin = ModAPI.LoadTexture("sprites/kazioman.png");
            var bone = ModAPI.LoadTexture("sprites/bonesub.png");
            var flesh = ModAPI.LoadTexture("sprites/flesh.png");


            //get person
            var person = Instance.GetComponent<PersonBehaviour>();

            //use the helper function to set each texture
            //parameters are as follows: 
            //  skin texture, flesh texture, bone texture, sprite scale
            //you can pass "null" to fall back to the original texture
            person.SetBodyTextures(skin, flesh, bone, 1);

            //change procedural damage colours if they interfere with your texture (rgb 0-255)
            person.SetBruiseColor(86, 62, 130); //main bruise colour. purple-ish by default
            person.SetSecondBruiseColor(154, 0, 7); //second bruise colour. red by default
            person.SetThirdBruiseColor(207, 206, 120); // third bruise colour. light yellow by default
            person.SetRottenColour(202, 199, 104); // rotten/zombie colour. light yellow/green by default
            person.SetBloodColour(108, 0, 4); // blood colour. dark red by default. note that this does not change decal nor particle effect colours. it only affects the procedural blood color which may or may not be rendered


                        var head = Instance.transform.Find("Head");
                        var childObject = new GameObject("Helmet");
                        childObject.transform.SetParent(head);
                        childObject.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite = childObject.AddComponent<SpriteRenderer>();
                        childSprite.sprite = ModAPI.LoadSprite("sprites/kmouth.png");
                        childSprite.sortingLayerName = "Back";

                        var childObject12 = new GameObject("Helmet2");
                        childObject12.transform.SetParent(head);
                        childObject12.transform.localPosition = new Vector3(0f, 0f); //edit position
                        childObject12.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //rotation
                        childObject12.transform.localScale = new Vector3(1f, 1f); //scale
                        var childSprite12 = childObject12.AddComponent<SpriteRenderer>();
                        childSprite12.sprite = ModAPI.LoadSprite("sprites/kears.png"); //put the name of your hat/helmet/mask sprite here
                        childSprite12.sortingLayerName = "Back";



                        var head13 = Instance.GetComponent<PersonBehaviour>().Limbs[3].transform;
                        var childObject13 = new GameObject("tail");
                        childObject13.transform.SetParent(head13);
                        childObject13.transform.localPosition = new Vector3(0f, 0f); //edit position
                        childObject13.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //rotation
                        childObject13.transform.localScale = new Vector3(1f, 1f); //scale
                        var childSprite13 = childObject13.AddComponent<SpriteRenderer>();
                        childSprite13.sprite = ModAPI.LoadSprite("sprites/ktails.png"); //put the name of your hat/helmet/mask sprite here
                        childSprite13.sortingLayerName = "Back";


                   foreach (var body in person.Limbs)
                                    {
                body.BaseStrength += 1f;
                body.Health *= 10f;
                body.InitialHealth *= 40f;
                body.ShotDamageMultiplier *= 0.01f;
                body.BreakingThreshold += 50f;
                body.RegenerationSpeed += 50f;
                body.DiscomfortingHeatTemperature = 50000f;
                body.IsLethalToBreak = false;
                body.ImpactPainMultiplier *= 0.0001f;
                body.Numbness *= 50f;
            }


                



        }

    }
);

                                  ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Human"), //item to derive from
        NameOverride = "Orange Fox [FST]", //new item name with a suffix to assure it is globally unique
        DescriptionOverride = "Full form", //new item description
        CategoryOverride = ModAPI.FindCategory("The Differences"), //new item category
        NameToOrderByOverride = "O",
        ThumbnailOverride = ModAPI.LoadSprite("sprites/view/orangefox.png"), //new item thumbnail (relative path)
        AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
        {
            //load textures for each layer (see Human textures folder in this repository)
            var skin = ModAPI.LoadTexture("sprites/base/base orange fox oh no gonna be nude x3.png");
            var bone = ModAPI.LoadTexture("sprites/bonesub.png");
            var flesh = ModAPI.LoadTexture("sprites/flesh.png");


            //get person
            var person = Instance.GetComponent<PersonBehaviour>();

            //use the helper function to set each texture
            //parameters are as follows: 
            //  skin texture, flesh texture, bone texture, sprite scale
            //you can pass "null" to fall back to the original texture
            person.SetBodyTextures(skin, flesh, bone, 1);

            //change procedural damage colours if they interfere with your texture (rgb 0-255)
            person.SetBruiseColor(86, 62, 130); //main bruise colour. purple-ish by default
            person.SetSecondBruiseColor(154, 0, 7); //second bruise colour. red by default
            person.SetThirdBruiseColor(207, 206, 120); // third bruise colour. light yellow by default
            person.SetRottenColour(202, 199, 104); // rotten/zombie colour. light yellow/green by default
            person.SetBloodColour(108, 0, 4); // blood colour. dark red by default. note that this does not change decal nor particle effect colours. it only affects the procedural blood color which may or may not be rendered


                        var head = Instance.transform.Find("Head");
                        var childObject = new GameObject("Helmet");
                        childObject.transform.SetParent(head);
                        childObject.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite = childObject.AddComponent<SpriteRenderer>();
                        childSprite.sprite = ModAPI.LoadSprite("sprites/omonth.png");
                        childSprite.sortingLayerName = "Back";

                        var childObject12 = new GameObject("Helmet2");
                        childObject12.transform.SetParent(head);
                        childObject12.transform.localPosition = new Vector3(0f, 0f); //edit position
                        childObject12.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //rotation
                        childObject12.transform.localScale = new Vector3(1f, 1f); //scale
                        var childSprite12 = childObject12.AddComponent<SpriteRenderer>();
                        childSprite12.sprite = ModAPI.LoadSprite("sprites/oear.png"); //put the name of your hat/helmet/mask sprite here
                        childSprite12.sortingLayerName = "Back";



                        var head13 = Instance.GetComponent<PersonBehaviour>().Limbs[3].transform;
                        var childObject13 = new GameObject("tail");
                        childObject13.transform.SetParent(head13);
                        childObject13.transform.localPosition = new Vector3(0f, 0f); //edit position
                        childObject13.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //rotation
                        childObject13.transform.localScale = new Vector3(1f, 1f); //scale
                        var childSprite13 = childObject13.AddComponent<SpriteRenderer>();
                        childSprite13.sprite = ModAPI.LoadSprite("sprites/otail.png"); //put the name of your hat/helmet/mask sprite here
                        childSprite13.sortingLayerName = "Back";


                   foreach (var body in person.Limbs)
                                    {
                body.BaseStrength += 2f;
                body.Health *= 40f;
                body.InitialHealth *= 40f;
                body.SpeciesIdentity = "Sub-Human";
                body.ShotDamageMultiplier *= 0.01f;
                body.BreakingThreshold += 50f;
                body.RegenerationSpeed += 50f;
                body.DiscomfortingHeatTemperature = 50000f;
                body.IsLethalToBreak = false;
                body.ImpactPainMultiplier *= 0.0001f;
                body.Numbness *= 50f;
            }


                



        }

    }
);


                                ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Human"), //item to derive from
        NameOverride = "School Orange Fox [FST]", //new item name with a suffix to assure it is globally unique
        DescriptionOverride = "Clothed, in a school outfit! how cute! their body count is higher than 100. lets go to school! :D", //new item description
        CategoryOverride = ModAPI.FindCategory("The Differences"), //new item category
        NameToOrderByOverride = "O",
        ThumbnailOverride = ModAPI.LoadSprite("sprites/view/orangefoxschool.png"), //new item thumbnail (relative path)
        AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
        {
            //load textures for each layer (see Human textures folder in this repository)
            var skin = ModAPI.LoadTexture("sprites/boy orange.png");
            var bone = ModAPI.LoadTexture("sprites/bonesub.png");
            var flesh = ModAPI.LoadTexture("sprites/flesh.png");


            //get person
            var person = Instance.GetComponent<PersonBehaviour>();

            //use the helper function to set each texture
            //parameters are as follows: 
            //  skin texture, flesh texture, bone texture, sprite scale
            //you can pass "null" to fall back to the original texture
            person.SetBodyTextures(skin, flesh, bone, 1);

            //change procedural damage colours if they interfere with your texture (rgb 0-255)
            person.SetBruiseColor(86, 62, 130); //main bruise colour. purple-ish by default
            person.SetSecondBruiseColor(154, 0, 7); //second bruise colour. red by default
            person.SetThirdBruiseColor(207, 206, 120); // third bruise colour. light yellow by default
            person.SetRottenColour(202, 199, 104); // rotten/zombie colour. light yellow/green by default
            person.SetBloodColour(108, 0, 4); // blood colour. dark red by default. note that this does not change decal nor particle effect colours. it only affects the procedural blood color which may or may not be rendered


                        var head = Instance.transform.Find("Head");
                        var childObject = new GameObject("Helmet");
                        childObject.transform.SetParent(head);
                        childObject.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite = childObject.AddComponent<SpriteRenderer>();
                        childSprite.sprite = ModAPI.LoadSprite("sprites/omonth.png");
                        childSprite.sortingLayerName = "Back";

                        var childObject12 = new GameObject("Helmet2");
                        childObject12.transform.SetParent(head);
                        childObject12.transform.localPosition = new Vector3(0f, 0f); //edit position
                        childObject12.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //rotation
                        childObject12.transform.localScale = new Vector3(1f, 1f); //scale
                        var childSprite12 = childObject12.AddComponent<SpriteRenderer>();
                        childSprite12.sprite = ModAPI.LoadSprite("sprites/oear.png"); //put the name of your hat/helmet/mask sprite here
                        childSprite12.sortingLayerName = "Back";



                        var head13 = Instance.GetComponent<PersonBehaviour>().Limbs[3].transform;
                        var childObject13 = new GameObject("tail");
                        childObject13.transform.SetParent(head13);
                        childObject13.transform.localPosition = new Vector3(0f, 0f); //edit position
                        childObject13.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //rotation
                        childObject13.transform.localScale = new Vector3(1f, 1f); //scale
                        var childSprite13 = childObject13.AddComponent<SpriteRenderer>();
                        childSprite13.sprite = ModAPI.LoadSprite("sprites/otail.png"); //put the name of your hat/helmet/mask sprite here
                        childSprite13.sortingLayerName = "Back";

                                         foreach (var limb in person.Limbs)
                    {
                        var HumanSprites = limb.gameObject.GetOrAddComponent<RandomHumanTextureBehaviour>();
                        HumanSprites.person = person;
                        HumanSprites.Textures.Add(ModAPI.LoadTexture("sprites/girl orange.png"));
                        HumanSprites.Textures.Add(ModAPI.LoadTexture("sprites/boy orange.png"));



                    } 


                   foreach (var body in person.Limbs)
                                    {
                body.BaseStrength += 2f;
                body.Health *= 40f;
                body.InitialHealth *= 40f;
                body.SpeciesIdentity = "Sub-Human";
                body.ShotDamageMultiplier *= 0.01f;
                body.BreakingThreshold += 50f;
                body.RegenerationSpeed += 50f;
                body.DiscomfortingHeatTemperature = 50000f;
                body.IsLethalToBreak = false;
                body.ImpactPainMultiplier *= 0.0001f;
                body.Numbness *= 50f;
            }


                



        }

    }
);


                              ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Human"), //item to derive from
        NameOverride = "School Human [FST]", //new item name with a suffix to assure it is globally unique
        DescriptionOverride = "Clothed, in a school outfit! how cute! lets go to school! :D", //new item description
        CategoryOverride = ModAPI.FindCategory("The Differences"), //new item category
        NameToOrderByOverride = "O",
        ThumbnailOverride = ModAPI.LoadSprite("sprites/view/school.png"), //new item thumbnail (relative path)
        AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
        {
            //load textures for each layer (see Human textures folder in this repository)
            var skin = ModAPI.LoadTexture("sprites/boy orange.png");
            var bone = ModAPI.LoadTexture("sprites/bone.png");
            var flesh = ModAPI.LoadTexture("sprites/flesh.png");


            //get person
            var person = Instance.GetComponent<PersonBehaviour>();

            //use the helper function to set each texture
            //parameters are as follows: 
            //  skin texture, flesh texture, bone texture, sprite scale
            //you can pass "null" to fall back to the original texture
            person.SetBodyTextures(skin, flesh, bone, 1);

            //change procedural damage colours if they interfere with your texture (rgb 0-255)
            person.SetBruiseColor(86, 62, 130); //main bruise colour. purple-ish by default
            person.SetSecondBruiseColor(154, 0, 7); //second bruise colour. red by default
            person.SetThirdBruiseColor(207, 206, 120); // third bruise colour. light yellow by default
            person.SetRottenColour(202, 199, 104); // rotten/zombie colour. light yellow/green by default
            person.SetBloodColour(108, 0, 4); // blood colour. dark red by default. note that this does not change decal nor particle effect colours. it only affects the procedural blood color which may or may not be rendered



                                         foreach (var limb in person.Limbs)
                    {
                        var HumanSprites = limb.gameObject.GetOrAddComponent<RandomHumanTextureBehaviour>();
                        HumanSprites.person = person;
                        HumanSprites.Textures.Add(ModAPI.LoadTexture("sprites/human.png"));                       
                        HumanSprites.Textures.Add(ModAPI.LoadTexture("sprites/human2.png"));
                        HumanSprites.Textures.Add(ModAPI.LoadTexture("sprites/human3.png"));                       
                        HumanSprites.Textures.Add(ModAPI.LoadTexture("sprites/humanm.png"));                       
                        HumanSprites.Textures.Add(ModAPI.LoadTexture("sprites/humanm1.png"));
                        HumanSprites.Textures.Add(ModAPI.LoadTexture("sprites/humanm2.png"));
                        HumanSprites.Textures.Add(ModAPI.LoadTexture("sprites/humanm3.png"));                       
                        HumanSprites.Textures.Add(ModAPI.LoadTexture("sprites/humanm4.png"));
                        HumanSprites.Textures.Add(ModAPI.LoadTexture("sprites/humanm5.png"));
                                                HumanSprites.Textures.Add(ModAPI.LoadTexture("sprites/humanm6.png"));



                    } 




                



        }

    }
);


                                  ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Human"), //item to derive from
        NameOverride = "Artic Fox [FST]", //new item name with a suffix to assure it is globally unique
        DescriptionOverride = "Full form", //new item description
        CategoryOverride = ModAPI.FindCategory("The Differences"), //new item category
        NameToOrderByOverride = "B",
        ThumbnailOverride = ModAPI.LoadSprite("sprites/view/artic.png"), //new item thumbnail (relative path)
        AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
        {
            //load textures for each layer (see Human textures folder in this repository)
            var skin = ModAPI.LoadTexture("sprites/base/base artic fox oh no gonna be nude x3.png");
            var bone = ModAPI.LoadTexture("sprites/bonesub.png");
            var flesh = ModAPI.LoadTexture("sprites/flesh.png");


            //get person
            var person = Instance.GetComponent<PersonBehaviour>();

            //use the helper function to set each texture
            //parameters are as follows: 
            //  skin texture, flesh texture, bone texture, sprite scale
            //you can pass "null" to fall back to the original texture
            person.SetBodyTextures(skin, flesh, bone, 1);

            //change procedural damage colours if they interfere with your texture (rgb 0-255)
            person.SetBruiseColor(86, 62, 130); //main bruise colour. purple-ish by default
            person.SetSecondBruiseColor(154, 0, 7); //second bruise colour. red by default
            person.SetThirdBruiseColor(207, 206, 120); // third bruise colour. light yellow by default
            person.SetRottenColour(202, 199, 104); // rotten/zombie colour. light yellow/green by default
            person.SetBloodColour(108, 0, 4); // blood colour. dark red by default. note that this does not change decal nor particle effect colours. it only affects the procedural blood color which may or may not be rendered


                        var head = Instance.transform.Find("Head");
                        var childObject = new GameObject("Helmet");
                        childObject.transform.SetParent(head);
                        childObject.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite = childObject.AddComponent<SpriteRenderer>();
                        childSprite.sprite = ModAPI.LoadSprite("sprites/amonrth.png");
                        childSprite.sortingLayerName = "Back";

                        var childObject12 = new GameObject("Helmet2");
                        childObject12.transform.SetParent(head);
                        childObject12.transform.localPosition = new Vector3(0f, 0f); //edit position
                        childObject12.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //rotation
                        childObject12.transform.localScale = new Vector3(1f, 1f); //scale
                        var childSprite12 = childObject12.AddComponent<SpriteRenderer>();
                        childSprite12.sprite = ModAPI.LoadSprite("sprites/aear.png"); //put the name of your hat/helmet/mask sprite here
                        childSprite12.sortingLayerName = "Back";



                        var head13 = Instance.GetComponent<PersonBehaviour>().Limbs[3].transform;
                        var childObject13 = new GameObject("tail");
                        childObject13.transform.SetParent(head13);
                        childObject13.transform.localPosition = new Vector3(0f, 0f); //edit position
                        childObject13.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //rotation
                        childObject13.transform.localScale = new Vector3(1f, 1f); //scale
                        var childSprite13 = childObject13.AddComponent<SpriteRenderer>();
                        childSprite13.sprite = ModAPI.LoadSprite("sprites/atail.png"); //put the name of your hat/helmet/mask sprite here
                        childSprite13.sortingLayerName = "Back";


                   foreach (var body in person.Limbs)
                                    {
                body.BaseStrength += 2f;
                body.Health *= 40f;
                body.SpeciesIdentity = "Sub-Human";
                body.InitialHealth *= 40f;
                body.ShotDamageMultiplier *= 0.01f;
                body.BreakingThreshold += 50f;
                body.RegenerationSpeed += 50f;
                body.DiscomfortingHeatTemperature = 50000f;
                body.IsLethalToBreak = false;
                body.ImpactPainMultiplier *= 0.0001f;
                body.Numbness *= 50f;
            }


                



        }

    }
);



                                  ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Human"), //item to derive from
        NameOverride = "Black Fox [FST]", //new item name with a suffix to assure it is globally unique
        DescriptionOverride = "Full form", //new item description
        CategoryOverride = ModAPI.FindCategory("The Differences"), //new item category
        NameToOrderByOverride = "B",
        ThumbnailOverride = ModAPI.LoadSprite("sprites/view/blackfox.png"), //new item thumbnail (relative path)
        AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
        {
            //load textures for each layer (see Human textures folder in this repository)
            var skin = ModAPI.LoadTexture("sprites/base/base black fox oh no gonna be nude x3.png");
            var bone = ModAPI.LoadTexture("sprites/bonesub.png");
            var flesh = ModAPI.LoadTexture("sprites/flesh.png");


            //get person
            var person = Instance.GetComponent<PersonBehaviour>();

            //use the helper function to set each texture
            //parameters are as follows: 
            //  skin texture, flesh texture, bone texture, sprite scale
            //you can pass "null" to fall back to the original texture
            person.SetBodyTextures(skin, flesh, bone, 1);

            //change procedural damage colours if they interfere with your texture (rgb 0-255)
            person.SetBruiseColor(86, 62, 130); //main bruise colour. purple-ish by default
            person.SetSecondBruiseColor(154, 0, 7); //second bruise colour. red by default
            person.SetThirdBruiseColor(207, 206, 120); // third bruise colour. light yellow by default
            person.SetRottenColour(202, 199, 104); // rotten/zombie colour. light yellow/green by default
            person.SetBloodColour(108, 0, 4); // blood colour. dark red by default. note that this does not change decal nor particle effect colours. it only affects the procedural blood color which may or may not be rendered


                        var head = Instance.transform.Find("Head");
                        var childObject = new GameObject("Helmet");
                        childObject.transform.SetParent(head);
                        childObject.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite = childObject.AddComponent<SpriteRenderer>();
                        childSprite.sprite = ModAPI.LoadSprite("sprites/bmoth.png");
                        childSprite.sortingLayerName = "Back";

                        var childObject12 = new GameObject("Helmet2");
                        childObject12.transform.SetParent(head);
                        childObject12.transform.localPosition = new Vector3(0f, 0f); //edit position
                        childObject12.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //rotation
                        childObject12.transform.localScale = new Vector3(1f, 1f); //scale
                        var childSprite12 = childObject12.AddComponent<SpriteRenderer>();
                        childSprite12.sprite = ModAPI.LoadSprite("sprites/bear.png"); //put the name of your hat/helmet/mask sprite here
                        childSprite12.sortingLayerName = "Back";



                        var head13 = Instance.GetComponent<PersonBehaviour>().Limbs[3].transform;
                        var childObject13 = new GameObject("tail");
                        childObject13.transform.SetParent(head13);
                        childObject13.transform.localPosition = new Vector3(0f, 0f); //edit position
                        childObject13.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //rotation
                        childObject13.transform.localScale = new Vector3(1f, 1f); //scale
                        var childSprite13 = childObject13.AddComponent<SpriteRenderer>();
                        childSprite13.sprite = ModAPI.LoadSprite("sprites/btail.png"); //put the name of your hat/helmet/mask sprite here
                        childSprite13.sortingLayerName = "Back";

                        


                   foreach (var body in person.Limbs)
                                    {
                body.BaseStrength += 2f;
                body.Health *= 40f;
                body.SpeciesIdentity = "Sub-Human";
                body.InitialHealth *= 40f;
                body.ShotDamageMultiplier *= 0.01f;
                body.BreakingThreshold += 50f;
                body.RegenerationSpeed += 50f;
                body.DiscomfortingHeatTemperature = 50000f;
                body.IsLethalToBreak = false;
                body.ImpactPainMultiplier *= 0.0001f;
                body.Numbness *= 50f;
            }


                



        }

    }
);


                                 ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Human"), //item to derive from
        NameOverride = "Millitary Black Fox [FST]", //new item name with a suffix to assure it is globally unique
        DescriptionOverride = "Clothed in millitary entire, their normal appearance, come on, you would go out naked would you? you would? ew.", //new item description
        CategoryOverride = ModAPI.FindCategory("The Differences"), //new item category
        NameToOrderByOverride = "B",
        ThumbnailOverride = ModAPI.LoadSprite("sprites/view/blackmilltary.png"), //new item thumbnail (relative path)
        AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
        {
            //load textures for each layer (see Human textures folder in this repository)
            var skin = ModAPI.LoadTexture("sprites/milltary blackfoxshoes.png");
            var bone = ModAPI.LoadTexture("sprites/bonesub.png");
            var flesh = ModAPI.LoadTexture("sprites/flesh.png");


            //get person
            var person = Instance.GetComponent<PersonBehaviour>();

            //use the helper function to set each texture
            //parameters are as follows: 
            //  skin texture, flesh texture, bone texture, sprite scale
            //you can pass "null" to fall back to the original texture
            person.SetBodyTextures(skin, flesh, bone, 1);

            //change procedural damage colours if they interfere with your texture (rgb 0-255)
            person.SetBruiseColor(86, 62, 130); //main bruise colour. purple-ish by default
            person.SetSecondBruiseColor(154, 0, 7); //second bruise colour. red by default
            person.SetThirdBruiseColor(207, 206, 120); // third bruise colour. light yellow by default
            person.SetRottenColour(202, 199, 104); // rotten/zombie colour. light yellow/green by default
            person.SetBloodColour(108, 0, 4); // blood colour. dark red by default. note that this does not change decal nor particle effect colours. it only affects the procedural blood color which may or may not be rendered


                        var head = Instance.transform.Find("Head");
                        var childObject = new GameObject("Helmet");
                        childObject.transform.SetParent(head);
                        childObject.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite = childObject.AddComponent<SpriteRenderer>();
                        childSprite.sprite = ModAPI.LoadSprite("sprites/bmoth.png");
                        childSprite.sortingLayerName = "Back";

                        var childObject12 = new GameObject("Helmet2");
                        childObject12.transform.SetParent(head);
                        childObject12.transform.localPosition = new Vector3(0f, 0f); //edit position
                        childObject12.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //rotation
                        childObject12.transform.localScale = new Vector3(1f, 1f); //scale
                        var childSprite12 = childObject12.AddComponent<SpriteRenderer>();
                        childSprite12.sprite = ModAPI.LoadSprite("sprites/bear.png"); //put the name of your hat/helmet/mask sprite here
                        childSprite12.sortingLayerName = "Back";



                        var head13 = Instance.GetComponent<PersonBehaviour>().Limbs[3].transform;
                        var childObject13 = new GameObject("tail");
                        childObject13.transform.SetParent(head13);
                        childObject13.transform.localPosition = new Vector3(0f, 0f); //edit position
                        childObject13.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //rotation
                        childObject13.transform.localScale = new Vector3(1f, 1f); //scale
                        var childSprite13 = childObject13.AddComponent<SpriteRenderer>();
                        childSprite13.sprite = ModAPI.LoadSprite("sprites/btail.png"); //put the name of your hat/helmet/mask sprite here
                        childSprite13.sortingLayerName = "Back";


                                                                 foreach (var limb in person.Limbs)
                    {
                        var HumanSprites = limb.gameObject.GetOrAddComponent<RandomHumanTextureBehaviour>();
                        HumanSprites.person = person;
                        HumanSprites.Textures.Add(ModAPI.LoadTexture("sprites/milltary blackfox.png"));
                        HumanSprites.Textures.Add(ModAPI.LoadTexture("sprites/milltary blackfoxshoes.png"));



                    } 


                   foreach (var body in person.Limbs)
                                    {
                body.BaseStrength += 2f;
                body.Health *= 40f;
                body.SpeciesIdentity = "Sub-Human";
                body.InitialHealth *= 40f;
                body.ShotDamageMultiplier *= 0.01f;
                body.BreakingThreshold += 50f;
                body.RegenerationSpeed += 50f;
                body.DiscomfortingHeatTemperature = 50000f;
                body.IsLethalToBreak = false;
                body.ImpactPainMultiplier *= 0.0001f;
                body.Numbness *= 50f;
                
                                if (body.gameObject.name == "UpperBody" || body.gameObject.name == "MiddleBody" || body.gameObject.name == "LowerBody" || body.gameObject.name == "UpperLegFront" || body.gameObject.name == "LowerLegFront" || body.gameObject.name == "UpperLeg" || body.gameObject.name == "LowerLeg" || body.gameObject.name == "UpperArmFront" || body.gameObject.name == "UpperLegFront" || body.gameObject.name == "LowerLegFront" || body.gameObject.name == "UpperLeg" || body.gameObject.name == "LowerLeg" || body.gameObject.name == "UpperArmFront" || body.gameObject.name == "LowerArmFront" || body.gameObject.name == "UpperArm" || body.gameObject.name == "LowerArm")
                      {
                      body.PhysicalBehaviour.Properties = ModAPI.FindPhysicalProperties("AndroidArmour");
                      body.ImmuneToDamage = true;
			          body.CirculationBehaviour.ImmuneToDamage = true;
                      }

            }


                



        }

    }
);


                                 ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Human"), //item to derive from
        NameOverride = "Millitary Human [FST]", //new item name with a suffix to assure it is globally unique
        DescriptionOverride = "If it moves shoot it, the foxes can stand a shoot!", //new item description
        CategoryOverride = ModAPI.FindCategory("The Differences"), //new item category
        NameToOrderByOverride = "B",
        ThumbnailOverride = ModAPI.LoadSprite("sprites/view/blackmilltary.png"), //new item thumbnail (relative path)
        AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
        {
            //load textures for each layer (see Human textures folder in this repository)
            var skin = ModAPI.LoadTexture("sprites/milltary person.png");
            var bone = ModAPI.LoadTexture("sprites/bone.png");
            var flesh = ModAPI.LoadTexture("sprites/flesh.png");


            //get person
            var person = Instance.GetComponent<PersonBehaviour>();

            //use the helper function to set each texture
            //parameters are as follows: 
            //  skin texture, flesh texture, bone texture, sprite scale
            //you can pass "null" to fall back to the original texture
            person.SetBodyTextures(skin, flesh, bone, 1);

            //change procedural damage colours if they interfere with your texture (rgb 0-255)
            person.SetBruiseColor(86, 62, 130); //main bruise colour. purple-ish by default
            person.SetSecondBruiseColor(154, 0, 7); //second bruise colour. red by default
            person.SetThirdBruiseColor(207, 206, 120); // third bruise colour. light yellow by default
            person.SetRottenColour(202, 199, 104); // rotten/zombie colour. light yellow/green by default
            person.SetBloodColour(108, 0, 4); // blood colour. dark red by default. note that this does not change decal nor particle effect colours. it only affects the procedural blood color which may or may not be rendered





                                                                 foreach (var limb in person.Limbs)
                    {
                        var HumanSprites = limb.gameObject.GetOrAddComponent<RandomHumanTextureBehaviour>();
                        HumanSprites.person = person;
                        HumanSprites.Textures.Add(ModAPI.LoadTexture("sprites/milltary person1.png"));
                        HumanSprites.Textures.Add(ModAPI.LoadTexture("sprites/milltary person2.png"));
                        HumanSprites.Textures.Add(ModAPI.LoadTexture("sprites/milltary person.png"));
                        HumanSprites.Textures.Add(ModAPI.LoadTexture("sprites/milltary person3.png"));
                        HumanSprites.Textures.Add(ModAPI.LoadTexture("sprites/milltary person4.png"));
                        HumanSprites.Textures.Add(ModAPI.LoadTexture("sprites/milltary person5.png"));



                    } 


                   foreach (var body in person.Limbs)
                                    {
                body.BaseStrength += 2f;
                body.Health *= 40f;
                body.InitialHealth *= 40f;

                
                                if (body.gameObject.name == "UpperBody" || body.gameObject.name == "MiddleBody" || body.gameObject.name == "LowerBody")
                                {
                      body.PhysicalBehaviour.Properties = ModAPI.FindPhysicalProperties("AndroidArmour");
			          body.CirculationBehaviour.ImmuneToDamage = true;
                      }

            }


                



        }

    }
);


                                 ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Human"), //item to derive from
        NameOverride = "Priate Artic Fox [FST]", //new item name with a suffix to assure it is globally unique
        DescriptionOverride = "Clothed in priate entire, their normal appearance, come on, you would go out naked would you? you would? ew. like stealing your hearts!", //new item description
        CategoryOverride = ModAPI.FindCategory("The Differences"), //new item category
        NameToOrderByOverride = "A",
        ThumbnailOverride = ModAPI.LoadSprite("sprites/view/priate.png"), //new item thumbnail (relative path)
        AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
        {
            //load textures for each layer (see Human textures folder in this repository)
            var skin = ModAPI.LoadTexture("sprites/Priate Artic fox.png");
            var bone = ModAPI.LoadTexture("sprites/bonesub.png");
            var flesh = ModAPI.LoadTexture("sprites/flesh.png");


            //get person
            var person = Instance.GetComponent<PersonBehaviour>();

            //use the helper function to set each texture
            //parameters are as follows: 
            //  skin texture, flesh texture, bone texture, sprite scale
            //you can pass "null" to fall back to the original texture
            person.SetBodyTextures(skin, flesh, bone, 1);

            //change procedural damage colours if they interfere with your texture (rgb 0-255)
            person.SetBruiseColor(86, 62, 130); //main bruise colour. purple-ish by default
            person.SetSecondBruiseColor(154, 0, 7); //second bruise colour. red by default
            person.SetThirdBruiseColor(207, 206, 120); // third bruise colour. light yellow by default
            person.SetRottenColour(202, 199, 104); // rotten/zombie colour. light yellow/green by default
            person.SetBloodColour(108, 0, 4); // blood colour. dark red by default. note that this does not change decal nor particle effect colours. it only affects the procedural blood color which may or may not be rendered



                        var head = Instance.transform.Find("Head");
                        var childObject = new GameObject("Helmet");
                        childObject.transform.SetParent(head);
                        childObject.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite = childObject.AddComponent<SpriteRenderer>();
                        childSprite.sprite = ModAPI.LoadSprite("sprites/amonrth.png");
                        childSprite.sortingLayerName = "Back";

                        var childObject12 = new GameObject("Helmet2");
                        childObject12.transform.SetParent(head);
                        childObject12.transform.localPosition = new Vector3(0f, 0f); //edit position
                        childObject12.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //rotation
                        childObject12.transform.localScale = new Vector3(1f, 1f); //scale
                        var childSprite12 = childObject12.AddComponent<SpriteRenderer>();
                        childSprite12.sprite = ModAPI.LoadSprite("sprites/aear.png"); //put the name of your hat/helmet/mask sprite here
                        childSprite12.sortingLayerName = "Back";



                        var head13 = Instance.GetComponent<PersonBehaviour>().Limbs[3].transform;
                        var childObject13 = new GameObject("tail");
                        childObject13.transform.SetParent(head13);
                        childObject13.transform.localPosition = new Vector3(0f, 0f); //edit position
                        childObject13.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //rotation
                        childObject13.transform.localScale = new Vector3(1f, 1f); //scale
                        var childSprite13 = childObject13.AddComponent<SpriteRenderer>();
                        childSprite13.sprite = ModAPI.LoadSprite("sprites/atail.png"); //put the name of your hat/helmet/mask sprite here
                        childSprite13.sortingLayerName = "Back";


                                                                 foreach (var limb in person.Limbs)
                    {
                        var HumanSprites = limb.gameObject.GetOrAddComponent<RandomHumanTextureBehaviour>();
                        HumanSprites.person = person;
                        HumanSprites.Textures.Add(ModAPI.LoadTexture("sprites/Priate Girl Artic fox.png"));
                        HumanSprites.Textures.Add(ModAPI.LoadTexture("sprites/Priate Artic fox.png"));



                    } 


                   foreach (var body in person.Limbs)
                                    {
                body.BaseStrength += 2f;
                body.Health *= 40f;
                body.SpeciesIdentity = "Sub-Human";
                body.InitialHealth *= 40f;
                body.ShotDamageMultiplier *= 0.01f;
                body.BreakingThreshold += 50f;
                body.RegenerationSpeed += 50f;
                body.DiscomfortingHeatTemperature = 50000f;
                body.IsLethalToBreak = false;
                body.ImpactPainMultiplier *= 0.0001f;
                body.Numbness *= 50f;
                
                                if (body.gameObject.name == "UpperBody" || body.gameObject.name == "MiddleBody" || body.gameObject.name == "LowerBody" || body.gameObject.name == "UpperLegFront" || body.gameObject.name == "LowerLegFront" || body.gameObject.name == "UpperLeg" || body.gameObject.name == "LowerLeg" || body.gameObject.name == "UpperArmFront" || body.gameObject.name == "UpperLegFront" || body.gameObject.name == "LowerLegFront" || body.gameObject.name == "UpperLeg" || body.gameObject.name == "LowerLeg" || body.gameObject.name == "UpperArmFront" || body.gameObject.name == "LowerArmFront" || body.gameObject.name == "UpperArm" || body.gameObject.name == "LowerArm")
                      {
                      body.PhysicalBehaviour.Properties = ModAPI.FindPhysicalProperties("AndroidArmour");
                      body.ImmuneToDamage = true;
			          body.CirculationBehaviour.ImmuneToDamage = true;
                      }

            }


                



        }

    }
);


                                 ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Human"), //item to derive from
        NameOverride = "Priate captain Vulpes Nasha the Artic fox [FST]", //new item name with a suffix to assure it is globally unique
        DescriptionOverride = "HIIII!!! Omg your so, CUTE!! Jessey, show your brother!! oh wait, he left... eh, whatever lets just do girl shopping! - Vulpes", //new item description
        CategoryOverride = ModAPI.FindCategory("The Differences"), //new item category
        NameToOrderByOverride = "aMaincharacter",
        ThumbnailOverride = ModAPI.LoadSprite("sprites/view/vulpes.png"), //new item thumbnail (relative path)
        AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
        {
            //load textures for each layer (see Human textures folder in this repository)
            var skin = ModAPI.LoadTexture("sprites/Priate captain Vulpes the Artic fox.png");
            var bone = ModAPI.LoadTexture("sprites/bonesub.png");
            var flesh = ModAPI.LoadTexture("sprites/flesh.png");


            //get person
            var person = Instance.GetComponent<PersonBehaviour>();

            //use the helper function to set each texture
            //parameters are as follows: 
            //  skin texture, flesh texture, bone texture, sprite scale
            //you can pass "null" to fall back to the original texture
            person.SetBodyTextures(skin, flesh, bone, 1);

            //change procedural damage colours if they interfere with your texture (rgb 0-255)
            person.SetBruiseColor(86, 62, 130); //main bruise colour. purple-ish by default
            person.SetSecondBruiseColor(154, 0, 7); //second bruise colour. red by default
            person.SetThirdBruiseColor(207, 206, 120); // third bruise colour. light yellow by default
            person.SetRottenColour(202, 199, 104); // rotten/zombie colour. light yellow/green by default
            person.SetBloodColour(108, 0, 4); // blood colour. dark red by default. note that this does not change decal nor particle effect colours. it only affects the procedural blood color which may or may not be rendered



                        var head = Instance.transform.Find("Head");
                        var childObject = new GameObject("Helmet");
                        childObject.transform.SetParent(head);
                        childObject.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite = childObject.AddComponent<SpriteRenderer>();
                        childSprite.sprite = ModAPI.LoadSprite("sprites/amonrth.png");
                        childSprite.sortingLayerName = "Back";

                        var childObject12 = new GameObject("Helmet2");
                        childObject12.transform.SetParent(head);
                        childObject12.transform.localPosition = new Vector3(0f, 0f); //edit position
                        childObject12.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //rotation
                        childObject12.transform.localScale = new Vector3(1f, 1f); //scale
                        var childSprite12 = childObject12.AddComponent<SpriteRenderer>();
                        childSprite12.sprite = ModAPI.LoadSprite("sprites/aear.png"); //put the name of your hat/helmet/mask sprite here
                        childSprite12.sortingLayerName = "Back";



                        var head13 = Instance.GetComponent<PersonBehaviour>().Limbs[3].transform;
                        var childObject13 = new GameObject("tail");
                        childObject13.transform.SetParent(head13);
                        childObject13.transform.localPosition = new Vector3(0f, 0f); //edit position
                        childObject13.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //rotation
                        childObject13.transform.localScale = new Vector3(1f, 1f); //scale
                        var childSprite13 = childObject13.AddComponent<SpriteRenderer>();
                        childSprite13.sprite = ModAPI.LoadSprite("sprites/vulpes tail.png"); //put the name of your hat/helmet/mask sprite here
                        childSprite13.sortingLayerName = "Back";

                                                                        var deel72 = Instance.GetComponent<PersonBehaviour>().Limbs[0].transform;
                                                var childObject1 = new GameObject("Helmet");
                        var eyeBehaviour = childObject1.AddComponent<GorseEyeBehaviour>(); //head
                        var headLimbBehaviour = deel72.GetComponent<LimbBehaviour>();
                        childObject1.transform.SetParent(deel72);
                        childObject1.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject1.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject1.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite1 = childObject1.AddComponent<SpriteRenderer>();
                        childSprite1.sprite = ModAPI.LoadSprite("sprites/test eyes.png");
                        childSprite1.material = ModAPI.FindMaterial("VeryBright");
                        childSprite1.sortingLayerName = "Top";
                        eyeBehaviour.Limb = headLimbBehaviour;
                        eyeBehaviour.Renderer = childSprite1;
                        eyeBehaviour.LargeRange = new Vector2(0.01f, 0.01f);
                        eyeBehaviour.SmallRange = new Vector2(5.01f, 5.01f);





                   foreach (var body in person.Limbs)
                                    {
                body.BaseStrength += 10f;
                body.Health *= 10f;
                body.SpeciesIdentity = "Sub-Human";
                body.InitialHealth *= 10f;
                body.ShotDamageMultiplier *= 0.01f;
                body.BreakingThreshold += 50f;
                body.RegenerationSpeed += 50f;
                body.FreezingTemperature = float.NegativeInfinity;
                body.DiscomfortingHeatTemperature = float.PositiveInfinity;
                body.ExplodeLiquidAmount = float.PositiveInfinity;
                body.transform.root.localScale *= 1.01f;
                body.Numbness = float.PositiveInfinity;
                body.IsLethalToBreak = false;
                body.ImpactPainMultiplier *= 0.0001f;

                                      body.ImmuneToDamage = true;
			          body.CirculationBehaviour.ImmuneToDamage = true;
                
                                if (body.gameObject.name == "UpperBody" || body.gameObject.name == "MiddleBody" || body.gameObject.name == "LowerBody" || body.gameObject.name == "UpperLegFront" || body.gameObject.name == "LowerLegFront" || body.gameObject.name == "UpperLeg" || body.gameObject.name == "LowerLeg" || body.gameObject.name == "UpperArmFront" || body.gameObject.name == "UpperLegFront" || body.gameObject.name == "LowerLegFront" || body.gameObject.name == "UpperLeg" || body.gameObject.name == "LowerLeg" || body.gameObject.name == "UpperArmFront" || body.gameObject.name == "LowerArmFront" || body.gameObject.name == "UpperArm" || body.gameObject.name == "LowerArm")
                      {
                      body.PhysicalBehaviour.Properties = ModAPI.FindPhysicalProperties("AndroidArmour");
                      }

            }


                



        }

    }
);

                              ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Human"), //item to derive from
        NameOverride = "Ace Millitary Human [FST]", //new item name with a suffix to assure it is globally unique
        DescriptionOverride = "H- Human F- Fox A- Ace, The best of the best before Jessey and Andrew", //new item description
        CategoryOverride = ModAPI.FindCategory("The Differences"), //new item category
        NameToOrderByOverride = "B",
        ThumbnailOverride = ModAPI.LoadSprite("sprites/view/suprene andrew.png"), //new item thumbnail (relative path)
        AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
        {
            //load textures for each layer (see Human textures folder in this repository)
            var skin = ModAPI.LoadTexture("sprites/acebase.png");
            var bone = ModAPI.LoadTexture("sprites/bone.png");
            var flesh = ModAPI.LoadTexture("sprites/flesh.png");


            //get person
            var person = Instance.GetComponent<PersonBehaviour>();

            //use the helper function to set each texture
            //parameters are as follows: 
            //  skin texture, flesh texture, bone texture, sprite scale
            //you can pass "null" to fall back to the original texture
            person.SetBodyTextures(skin, flesh, bone, 1);

            //change procedural damage colours if they interfere with your texture (rgb 0-255)
            person.SetBruiseColor(86, 62, 130); //main bruise colour. purple-ish by default
            person.SetSecondBruiseColor(154, 0, 7); //second bruise colour. red by default
            person.SetThirdBruiseColor(207, 206, 120); // third bruise colour. light yellow by default
            person.SetRottenColour(202, 199, 104); // rotten/zombie colour. light yellow/green by default
            person.SetBloodColour(108, 0, 4); // blood colour. dark red by default. note that this does not change decal nor particle effect colours. it only affects the procedural blood color which may or may not be rendered

var childObject = new GameObject("Helmet");

 

                        var deel72 = Instance.GetComponent<PersonBehaviour>().Limbs[0].transform;
                        var childObject1 = new GameObject("Helmet");
                        var eyeBehaviour = childObject1.AddComponent<GorseEyeBehaviour>(); //head
                        var headLimbBehaviour = deel72.GetComponent<LimbBehaviour>();
                        childObject1.transform.SetParent(deel72);
                        childObject1.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject1.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject1.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite1 = childObject1.AddComponent<SpriteRenderer>();
                        childSprite1.sprite = ModAPI.LoadSprite("sprites/ace eye.png");
                        childSprite1.material = ModAPI.FindMaterial("VeryBright");
                        childSprite1.sortingLayerName = "Top";
                        eyeBehaviour.Limb = headLimbBehaviour;
                        eyeBehaviour.Renderer = childSprite1;
                        eyeBehaviour.LargeRange = new Vector2(0.01f, 0.01f);
                        eyeBehaviour.SmallRange = new Vector2(5.01f, 5.01f);

                            var eyeBehaviour14 = childObject.AddComponent<GorseEyeBehaviour>();
                        var deel14 = Instance.GetComponent<PersonBehaviour>().Limbs[13].transform; //lowerarm
                        var childObject14 = new GameObject("Helmet");
                        childObject14.transform.SetParent(deel14);
                        childObject14.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject14.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject14.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite14 = childObject14.AddComponent<SpriteRenderer>();
                        childSprite14.material = ModAPI.FindMaterial("VeryBright");
                        childSprite14.sprite = ModAPI.LoadSprite("sprites/acehand.png");
                        childSprite14.sortingLayerName = "Back";
                        var headLimbBehaviour14 = deel14.GetComponent<LimbBehaviour>();
                        eyeBehaviour14.Limb = headLimbBehaviour14;
                        eyeBehaviour14.Renderer = childSprite14;
                        eyeBehaviour14.LargeRange = new Vector2(0.01f, 0.01f);
                        eyeBehaviour14.SmallRange = new Vector2(5.01f, 5.01f);

                                                var eyeBehaviour12 = childObject.AddComponent<GorseEyeBehaviour>();
                        var deel12 = Instance.GetComponent<PersonBehaviour>().Limbs[11].transform; //lowerarm front
                        var childObject12 = new GameObject("Helmet");
                        childObject12.transform.SetParent(deel12);
                        childObject12.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject12.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject12.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite12 = childObject12.AddComponent<SpriteRenderer>();
                        childSprite12.material = ModAPI.FindMaterial("VeryBright");
                        childSprite12.sprite = ModAPI.LoadSprite("sprites/acehand.png");
                        childSprite12.sortingLayerName = "Top";
                        var headLimbBehaviour12 = deel12.GetComponent<LimbBehaviour>();
                        eyeBehaviour12.Limb = headLimbBehaviour12;
                        eyeBehaviour12.Renderer = childSprite12;
                        eyeBehaviour12.LargeRange = new Vector2(0.01f, 0.01f);
                        eyeBehaviour12.SmallRange = new Vector2(5.01f, 5.01f);





                   foreach (var body in person.Limbs)
                                    {



			          body.CirculationBehaviour.ImmuneToDamage = true;
            
                      body.PhysicalBehaviour.Properties = ModAPI.FindPhysicalProperties("AndroidArmour");
                      

                                if (body.gameObject.name == "LowerArmFront" || body.gameObject.name == "LowerArm")
                      {
body.GetComponent<AndroidSparkCreator>();


                  void OnEMPHit()
	{
			body.Health = 0f;
	}


                      }

                                    }

            


                



        }

    }
);

                              ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Human"), //item to derive from
        NameOverride = "Millitary Supreme commander Andrew Fox the Black Fox [FST]", //new item name with a suffix to assure it is globally unique
        DescriptionOverride = "I have 3 things I care about, Teammates, Fellow Foxes, and top of my list, my sister, so who says I care about you, James, but just this once, I will add a human to my list. Don't get used to it. - Andrew Fox Weapon of choice: Assault rifle", //new item description
        CategoryOverride = ModAPI.FindCategory("The Differences"), //new item category
        NameToOrderByOverride = "aMaincharacter",
        ThumbnailOverride = ModAPI.LoadSprite("sprites/view/suprene andrew.png"), //new item thumbnail (relative path)
        AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
        {
            //load textures for each layer (see Human textures folder in this repository)
            var skin = ModAPI.LoadTexture("sprites/millitary boss Andrew Fox.png");
            var bone = ModAPI.LoadTexture("sprites/bonesub.png");
            var flesh = ModAPI.LoadTexture("sprites/flesh.png");


            //get person
            var person = Instance.GetComponent<PersonBehaviour>();

            //use the helper function to set each texture
            //parameters are as follows: 
            //  skin texture, flesh texture, bone texture, sprite scale
            //you can pass "null" to fall back to the original texture
            person.SetBodyTextures(skin, flesh, bone, 1);

            //change procedural damage colours if they interfere with your texture (rgb 0-255)
            person.SetBruiseColor(86, 62, 130); //main bruise colour. purple-ish by default
            person.SetSecondBruiseColor(154, 0, 7); //second bruise colour. red by default
            person.SetThirdBruiseColor(207, 206, 120); // third bruise colour. light yellow by default
            person.SetRottenColour(202, 199, 104); // rotten/zombie colour. light yellow/green by default
            person.SetBloodColour(108, 0, 4); // blood colour. dark red by default. note that this does not change decal nor particle effect colours. it only affects the procedural blood color which may or may not be rendered



                        var head = Instance.transform.Find("Head");
                        var childObject = new GameObject("Helmet");
                        childObject.transform.SetParent(head);
                        childObject.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite = childObject.AddComponent<SpriteRenderer>();
                        childSprite.sprite = ModAPI.LoadSprite("sprites/bmoth.png");
                        childSprite.sortingLayerName = "Back";

                        var childObject12 = new GameObject("Helmet2");
                        childObject12.transform.SetParent(head);
                        childObject12.transform.localPosition = new Vector3(0f, 0f); //edit position
                        childObject12.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //rotation
                        childObject12.transform.localScale = new Vector3(1f, 1f); //scale
                        var childSprite12 = childObject12.AddComponent<SpriteRenderer>();
                        childSprite12.sprite = ModAPI.LoadSprite("sprites/bear.png"); //put the name of your hat/helmet/mask sprite here
                        childSprite12.sortingLayerName = "Back";



                        var head13 = Instance.GetComponent<PersonBehaviour>().Limbs[3].transform;
                        var childObject13 = new GameObject("tail");
                        childObject13.transform.SetParent(head13);
                        childObject13.transform.localPosition = new Vector3(0f, 0f); //edit position
                        childObject13.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //rotation
                        childObject13.transform.localScale = new Vector3(1f, 1f); //scale
                        var childSprite13 = childObject13.AddComponent<SpriteRenderer>();
                        childSprite13.sprite = ModAPI.LoadSprite("sprites/andrew tail.png"); //put the name of your hat/helmet/mask sprite here
                        childSprite13.sortingLayerName = "Back";

                                                                        var deel72 = Instance.GetComponent<PersonBehaviour>().Limbs[0].transform;
                                                var childObject1 = new GameObject("Helmet");
                        var eyeBehaviour = childObject1.AddComponent<GorseEyeBehaviour>(); //head
                        var headLimbBehaviour = deel72.GetComponent<LimbBehaviour>();
                        childObject1.transform.SetParent(deel72);
                        childObject1.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject1.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject1.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite1 = childObject1.AddComponent<SpriteRenderer>();
                        childSprite1.sprite = ModAPI.LoadSprite("sprites/test eye.png");
                        childSprite1.material = ModAPI.FindMaterial("VeryBright");
                        childSprite1.sortingLayerName = "Top";
                        eyeBehaviour.Limb = headLimbBehaviour;
                        eyeBehaviour.Renderer = childSprite1;
                        eyeBehaviour.LargeRange = new Vector2(0.01f, 0.01f);
                        eyeBehaviour.SmallRange = new Vector2(5.01f, 5.01f);





                   foreach (var body in person.Limbs)
                                    {
                body.BaseStrength += 12f;
                body.Health *= 10f;
                body.SpeciesIdentity = "Sub-Human";
                body.InitialHealth *= 10f;
                body.ShotDamageMultiplier *= 0.01f;
                body.BreakingThreshold += 50000f;
                body.RegenerationSpeed += float.PositiveInfinity;
                body.FreezingTemperature = float.NegativeInfinity;
                body.DiscomfortingHeatTemperature = float.PositiveInfinity;
                body.ExplodeLiquidAmount = float.PositiveInfinity;
                body.transform.root.localScale *= 1.015f;
                body.Numbness = float.PositiveInfinity;
                body.IsLethalToBreak = false;
                body.ImpactPainMultiplier *= 0.0001f;

                                      body.ImmuneToDamage = true;
			          body.CirculationBehaviour.ImmuneToDamage = true;
            
                      body.PhysicalBehaviour.Properties = ModAPI.FindPhysicalProperties("AndroidArmour");
                      }

            


                



        }

    }
);
                                  ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Human"), //item to derive from
        NameOverride = "Silver Fox [FST]", //new item name with a suffix to assure it is globally unique
        DescriptionOverride = "The Monster of foxes, doesn't hear out or talk or anything for that matter, just that screech, Failed evolution", //new item description
        CategoryOverride = ModAPI.FindCategory("The Differences"), //new item category
        NameToOrderByOverride = "S",
        ThumbnailOverride = ModAPI.LoadSprite("sprites/view/silver.png"), //new item thumbnail (relative path)
        AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
        {
            //load textures for each layer (see Human textures folder in this repository)
            var skin = ModAPI.LoadTexture("sprites/base/base silver fox oh no gonna be nude x3.png");
            var bone = ModAPI.LoadTexture("sprites/bonesub.png");
            var flesh = ModAPI.LoadTexture("sprites/flesh.png");


            //get person
            var person = Instance.GetComponent<PersonBehaviour>();

            //use the helper function to set each texture
            //parameters are as follows: 
            //  skin texture, flesh texture, bone texture, sprite scale
            //you can pass "null" to fall back to the original texture
            person.SetBodyTextures(skin, flesh, bone, 1);

            //change procedural damage colours if they interfere with your texture (rgb 0-255)
            person.SetBruiseColor(86, 62, 130); //main bruise colour. purple-ish by default
            person.SetSecondBruiseColor(154, 0, 7); //second bruise colour. red by default
            person.SetThirdBruiseColor(207, 206, 120); // third bruise colour. light yellow by default
            person.SetRottenColour(202, 199, 104); // rotten/zombie colour. light yellow/green by default
            person.SetBloodColour(108, 0, 4); // blood colour. dark red by default. note that this does not change decal nor particle effect colours. it only affects the procedural blood color which may or may not be rendered


                        var head = Instance.transform.Find("Head");
                        var childObject = new GameObject("Helmet");
                        childObject.transform.SetParent(head);
                        childObject.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite = childObject.AddComponent<SpriteRenderer>();
                        childSprite.sprite = ModAPI.LoadSprite("sprites/smorth.png");
                        childSprite.sortingLayerName = "Back";

                        var childObject12 = new GameObject("Helmet2");
                        childObject12.transform.SetParent(head);
                        childObject12.transform.localPosition = new Vector3(0f, 0f); //edit position
                        childObject12.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //rotation
                        childObject12.transform.localScale = new Vector3(1f, 1f); //scale
                        var childSprite12 = childObject12.AddComponent<SpriteRenderer>();
                        childSprite12.sprite = ModAPI.LoadSprite("sprites/sear.png"); //put the name of your hat/helmet/mask sprite here
                        childSprite12.sortingLayerName = "Back";



                        var head13 = Instance.GetComponent<PersonBehaviour>().Limbs[3].transform;
                        var childObject13 = new GameObject("tail");
                        childObject13.transform.SetParent(head13);
                        childObject13.transform.localPosition = new Vector3(0f, 0f); //edit position
                        childObject13.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //rotation
                        childObject13.transform.localScale = new Vector3(1f, 1f); //scale
                        var childSprite13 = childObject13.AddComponent<SpriteRenderer>();
                        childSprite13.sprite = ModAPI.LoadSprite("sprites/stail.png"); //put the name of your hat/helmet/mask sprite here
                        childSprite13.sortingLayerName = "Back";

                                                var deel72 = Instance.GetComponent<PersonBehaviour>().Limbs[0].transform;
                                                var childObject1 = new GameObject("Helmet");
                        var eyeBehaviour = childObject1.AddComponent<GorseEyeBehaviour>(); //head
                        var headLimbBehaviour = deel72.GetComponent<LimbBehaviour>();
                        childObject1.transform.SetParent(deel72);
                        childObject1.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject1.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject1.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite1 = childObject1.AddComponent<SpriteRenderer>();
                        childSprite1.sprite = ModAPI.LoadSprite("sprites/test eye.png");
                        childSprite1.material = ModAPI.FindMaterial("VeryBright");
                        childSprite1.sortingLayerName = "Top";
                        eyeBehaviour.Limb = headLimbBehaviour;
                        eyeBehaviour.Renderer = childSprite1;
                        eyeBehaviour.LargeRange = new Vector2(0.01f, 0.01f);
                        eyeBehaviour.SmallRange = new Vector2(5.01f, 5.01f);


                   foreach (var body in person.Limbs)
                                    {
                body.BaseStrength += 2f;
                body.Health *= 40f;
                body.SpeciesIdentity = "Failed Sub-Human";
                body.InitialHealth *= 40f;
                body.ShotDamageMultiplier *= 0.01f;
                body.BreakingThreshold += 50f;
                body.RegenerationSpeed += 50f;
                body.DiscomfortingHeatTemperature = 50000f;
                body.IsLethalToBreak = false;
                body.ImpactPainMultiplier *= 0.0001f;
                body.Numbness *= 50f;

                                if (body.gameObject.name == "LowerArmFront" || body.gameObject.name == "LowerArm")
                      {
                        if (body.gameObject.GetComponent<sharphandBehaviour>() == null)
                          {
                           body.gameObject.AddComponent<sharphandBehaviour>();
                          }
            }
                                    }

                


                                    
        }

    }
);
                                  ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Human"), //item to derive from
        NameOverride = "Purple Fox [FST]", //new item name with a suffix to assure it is globally unique
        DescriptionOverride = "Basicly the most powerful Fox", //new item description
        CategoryOverride = ModAPI.FindCategory("The Differences"), //new item category
        NameToOrderByOverride = "P",
        ThumbnailOverride = ModAPI.LoadSprite("sprites/view/purple.png"), //new item thumbnail (relative path)
        AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
        {
            //load textures for each layer (see Human textures folder in this repository)
            var skin = ModAPI.LoadTexture("sprites/Purple Fox.png");
            var bone = ModAPI.LoadTexture("sprites/bonesub.png");
            var flesh = ModAPI.LoadTexture("sprites/flesh.png");


            //get person
            var person = Instance.GetComponent<PersonBehaviour>();

            //use the helper function to set each texture
            //parameters are as follows: 
            //  skin texture, flesh texture, bone texture, sprite scale
            //you can pass "null" to fall back to the original texture
            person.SetBodyTextures(skin, flesh, bone, 1);

            //change procedural damage colours if they interfere with your texture (rgb 0-255)
            person.SetBruiseColor(86, 62, 130); //main bruise colour. purple-ish by default
            person.SetSecondBruiseColor(154, 0, 7); //second bruise colour. red by default
            person.SetThirdBruiseColor(207, 206, 120); // third bruise colour. light yellow by default
            person.SetRottenColour(202, 199, 104); // rotten/zombie colour. light yellow/green by default
            person.SetBloodColour(108, 0, 4); // blood colour. dark red by default. note that this does not change decal nor particle effect colours. it only affects the procedural blood color which may or may not be rendered


                        var head = Instance.transform.Find("Head");
                        var childObject = new GameObject("Helmet");
                        childObject.transform.SetParent(head);
                        childObject.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite = childObject.AddComponent<SpriteRenderer>();
                        childSprite.sprite = ModAPI.LoadSprite("sprites/pmonsth.png");
                        childSprite.sortingLayerName = "Back";

                        var childObject12 = new GameObject("Helmet2");
                        childObject12.transform.SetParent(head);
                        childObject12.transform.localPosition = new Vector3(0f, 0f); //edit position
                        childObject12.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //rotation
                        childObject12.transform.localScale = new Vector3(1f, 1f); //scale
                        var childSprite12 = childObject12.AddComponent<SpriteRenderer>();
                        childSprite12.sprite = ModAPI.LoadSprite("sprites/pear.png"); //put the name of your hat/helmet/mask sprite here
                        childSprite12.sortingLayerName = "Back";



                        var head13 = Instance.GetComponent<PersonBehaviour>().Limbs[3].transform;
                        var childObject13 = new GameObject("tail");
                        childObject13.transform.SetParent(head13);
                        childObject13.transform.localPosition = new Vector3(0f, 0f); //edit position
                        childObject13.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //rotation
                        childObject13.transform.localScale = new Vector3(1f, 1f); //scale
                        var childSprite13 = childObject13.AddComponent<SpriteRenderer>();
                        childSprite13.sprite = ModAPI.LoadSprite("sprites/ptails.png"); //put the name of your hat/helmet/mask sprite here
                        childSprite13.sortingLayerName = "Back";
                                                var deel72 = Instance.GetComponent<PersonBehaviour>().Limbs[0].transform;
                                                var childObject1 = new GameObject("Helmet");
                        var eyeBehaviour = childObject1.AddComponent<GorseEyeBehaviour>(); //head
                        var headLimbBehaviour = deel72.GetComponent<LimbBehaviour>();
                        childObject1.transform.SetParent(deel72);
                        childObject1.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject1.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject1.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite1 = childObject1.AddComponent<SpriteRenderer>();
                        childSprite1.sprite = ModAPI.LoadSprite("sprites/test eye.png");
                        childSprite1.material = ModAPI.FindMaterial("VeryBright");
                        childSprite1.sortingLayerName = "Top";
                        eyeBehaviour.Limb = headLimbBehaviour;
                        eyeBehaviour.Renderer = childSprite1;
                        eyeBehaviour.LargeRange = new Vector2(0.01f, 0.01f);
                        eyeBehaviour.SmallRange = new Vector2(5.01f, 5.01f);

            foreach (var body in person.Limbs)
            {

                body.ImmuneToDamage = true;
                body.transform.root.localScale *= 1.02f;
			    body.CirculationBehaviour.ImmuneToDamage = true;

            }



                   foreach (var body in person.Limbs)
                                    {
                body.BaseStrength += 60f;
                body.Health *= 1000f;
                body.SpeciesIdentity = "Golden Sub-Human";
                body.InitialHealth *= 1000f;
                body.ShotDamageMultiplier *= 0.01f;
                body.BreakingThreshold += 50f;
                body.RegenerationSpeed += 50f;
                body.FreezingTemperature = float.NegativeInfinity;
                body.DiscomfortingHeatTemperature = float.PositiveInfinity;
                body.ExplodeLiquidAmount = float.PositiveInfinity;
                body.Numbness = float.PositiveInfinity;
                body.IsLethalToBreak = false;
                body.ImpactPainMultiplier *= 0.0001f;
                body.Numbness *= 50f;




            }


                



        }

    }
);

                              ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Human"), //item to derive from
        NameOverride = "Golden Armored Fox [FST]", //new item name with a suffix to assure it is globally unique
        DescriptionOverride = "Most powerful fox. Kneel", //new item description
        CategoryOverride = ModAPI.FindCategory("The Differences"), //new item category
        NameToOrderByOverride = "P",
        ThumbnailOverride = ModAPI.LoadSprite("sprites/view/goldenfox.png"), //new item thumbnail (relative path)
        AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
        {
            //load textures for each layer (see Human textures folder in this repository)
            var skin = ModAPI.LoadTexture("sprites/gold purple fox.png");
            var bone = ModAPI.LoadTexture("sprites/bonesub.png");
            var flesh = ModAPI.LoadTexture("sprites/flesh.png");


            //get person
            var person = Instance.GetComponent<PersonBehaviour>();

            //use the helper function to set each texture
            //parameters are as follows: 
            //  skin texture, flesh texture, bone texture, sprite scale
            //you can pass "null" to fall back to the original texture
            person.SetBodyTextures(skin, flesh, bone, 1);

            //change procedural damage colours if they interfere with your texture (rgb 0-255)
            person.SetBruiseColor(86, 62, 130); //main bruise colour. purple-ish by default
            person.SetSecondBruiseColor(154, 0, 7); //second bruise colour. red by default
            person.SetThirdBruiseColor(207, 206, 120); // third bruise colour. light yellow by default
            person.SetRottenColour(202, 199, 104); // rotten/zombie colour. light yellow/green by default
            person.SetBloodColour(108, 0, 4); // blood colour. dark red by default. note that this does not change decal nor particle effect colours. it only affects the procedural blood color which may or may not be rendered


                        var head = Instance.transform.Find("Head");
                        var childObject = new GameObject("Helmet");
                        childObject.transform.SetParent(head);
                        childObject.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite = childObject.AddComponent<SpriteRenderer>();
                        childSprite.sprite = ModAPI.LoadSprite("sprites/gpmontsth.png");
                        childSprite.sortingLayerName = "Back";

                        var childObject12 = new GameObject("Helmet2");
                        childObject12.transform.SetParent(head);
                        childObject12.transform.localPosition = new Vector3(0f, 0f); //edit position
                        childObject12.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //rotation
                        childObject12.transform.localScale = new Vector3(1f, 1f); //scale
                        var childSprite12 = childObject12.AddComponent<SpriteRenderer>();
                        childSprite12.sprite = ModAPI.LoadSprite("sprites/gpear.png"); //put the name of your hat/helmet/mask sprite here
                        childSprite12.sortingLayerName = "Back";



                        var head13 = Instance.GetComponent<PersonBehaviour>().Limbs[3].transform;
                        var childObject13 = new GameObject("tail");
                        childObject13.transform.SetParent(head13);
                        childObject13.transform.localPosition = new Vector3(0f, 0f); //edit position
                        childObject13.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //rotation
                        childObject13.transform.localScale = new Vector3(1f, 1f); //scale
                        var childSprite13 = childObject13.AddComponent<SpriteRenderer>();
                        childSprite13.sprite = ModAPI.LoadSprite("sprites/gptails.png"); //put the name of your hat/helmet/mask sprite here
                        childSprite13.sortingLayerName = "Back";

                                                var deel72 = Instance.GetComponent<PersonBehaviour>().Limbs[0].transform;
                                                var childObject1 = new GameObject("Helmet");
                        var eyeBehaviour = childObject1.AddComponent<GorseEyeBehaviour>(); //head
                        var headLimbBehaviour = deel72.GetComponent<LimbBehaviour>();
                        childObject1.transform.SetParent(deel72);
                        childObject1.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject1.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject1.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite1 = childObject1.AddComponent<SpriteRenderer>();
                        childSprite1.sprite = ModAPI.LoadSprite("sprites/test eye.png");
                        childSprite1.material = ModAPI.FindMaterial("VeryBright");
                        childSprite1.sortingLayerName = "Top";
                        eyeBehaviour.Limb = headLimbBehaviour;
                        eyeBehaviour.Renderer = childSprite1;
                        eyeBehaviour.LargeRange = new Vector2(0.01f, 0.01f);
                        eyeBehaviour.SmallRange = new Vector2(5.01f, 5.01f);

            foreach (var body in person.Limbs)
            {

                body.ImmuneToDamage = true;
                body.transform.root.localScale *= 1.02f;
			    body.CirculationBehaviour.ImmuneToDamage = true;

            }



                   foreach (var body in person.Limbs)
                                    {
                body.BaseStrength += 60f;
                body.Health *= 10000000f;
                body.SpeciesIdentity = "Golden Sub-Human";
                body.InitialHealth *= 10000000f;
                body.ShotDamageMultiplier *= 0.01f;
                body.BreakingThreshold += 50f;
                body.RegenerationSpeed += 50f;
                body.FreezingTemperature = float.NegativeInfinity;
                body.DiscomfortingHeatTemperature = float.PositiveInfinity;
                body.ExplodeLiquidAmount = float.PositiveInfinity;
                body.Numbness = float.PositiveInfinity;
                body.IsLethalToBreak = false;
                body.ImpactPainMultiplier *= 0.0001f;
                body.Numbness *= 50f;
                                      body.PhysicalBehaviour.Properties = ModAPI.FindPhysicalProperties("AndroidArmour");
                                                if (body.gameObject.name == "LowerArmFront" || body.gameObject.name == "LowerArm")
                      {
                        if (body.gameObject.GetComponent<sharphandBehaviour>() == null)
                          {
                           body.gameObject.AddComponent<sharphandBehaviour>();
                          }
            }




            }


                



        }

    }
);


/*
 
            foreach (var body in person.Limbs)
            {
                body.BaseStrength += 25f;
                body.Health *= 15000f;
                body.InitialHealth *= 15000f;
                body.ShotDamageMultiplier *= 0f;
                body.BreakingThreshold += 15000f;
                body.BaseStrength += 25f;
                body.RegenerationSpeed += 15000f;
                body.DiscomfortingHeatTemperature = 999999999f;
                body.IsLethalToBreak = false;
                body.SpeciesIdentity = "God";
                body.ImpactPainMultiplier *= 0f;
                body.Numbness *= 1500000f;
            }
 
        
        

           ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Human"), //item to derive from
        NameOverride = "BlazingNova [SNS]", //new item name with a suffix to assure it is globally unique
        DescriptionOverride = "BlazingNova - You are nothing to me.", //new item description
        CategoryOverride = ModAPI.FindCategory("The Differences"), //new item category
        NameToOrderByOverride = "i",
        ThumbnailOverride = ModAPI.LoadSprite("sprites/view/blazing.png"), //new item thumbnail (relative path)
        AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
        {
            var person = Instance.GetComponent<PersonBehaviour>();
               //load textures for each layer (see Human textures folder in this repository)
            var skin = ModAPI.LoadTexture("sprites/blazingnova - Copy.png");
            var flesh = ModAPI.LoadTexture("sprites/blazingnova.png");
            var bone = ModAPI.LoadTexture("sprites/blazingnova - Copy (2).png");

 var deel = Instance.GetComponent<PersonBehaviour>().Limbs[0].transform;
                        var childObject = new GameObject("Helmet");
                        var eyeBehaviour = childObject.AddComponent<GorseEyeBehaviour>(); //head
                        var headLimbBehaviour = deel.GetComponent<LimbBehaviour>();
                        childObject.transform.SetParent(deel);
                        childObject.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite = childObject.AddComponent<SpriteRenderer>();
                        childSprite.sprite = ModAPI.LoadSprite("sprites/blazenova/1.png");
                        childSprite.material = ModAPI.FindMaterial("VeryBright");
                        childSprite.sortingLayerName = "Top";
                        eyeBehaviour.Limb = headLimbBehaviour;
                        eyeBehaviour.Renderer = childSprite;
                        eyeBehaviour.LargeRange = new Vector2(0.01f, 0.01f);
                        eyeBehaviour.SmallRange = new Vector2(5.01f, 5.01f);

                        var eyeBehaviour2 = childObject.AddComponent<GorseEyeBehaviour>();
                        var deel2 = Instance.GetComponent<PersonBehaviour>().Limbs[1].transform; //upperbody
                        var childObject2 = new GameObject("Helmet");
                        childObject2.transform.SetParent(deel2);
                        childObject2.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject2.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject2.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite2 = childObject2.AddComponent<SpriteRenderer>();
                        childSprite2.material = ModAPI.FindMaterial("VeryBright");
                        childSprite2.sprite = ModAPI.LoadSprite("sprites/blazenova/2.png");
                        childSprite2.sortingLayerName = "Top";
                        var headLimbBehaviour2 = deel2.GetComponent<LimbBehaviour>();
                        eyeBehaviour2.Limb = headLimbBehaviour2;
                        eyeBehaviour2.Renderer = childSprite2;
                        eyeBehaviour2.LargeRange = new Vector2(0.01f, 0.01f);
                        eyeBehaviour2.SmallRange = new Vector2(5.01f, 5.01f);

                        var eyeBehaviour3 = childObject.AddComponent<GorseEyeBehaviour>();
                        var deel3 = Instance.GetComponent<PersonBehaviour>().Limbs[2].transform; //middlebody
                        var childObject3 = new GameObject("Helmet");
                        childObject3.transform.SetParent(deel3);
                        childObject3.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject3.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject3.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite3 = childObject3.AddComponent<SpriteRenderer>();
                        childSprite3.material = ModAPI.FindMaterial("VeryBright");
                        childSprite3.sprite = ModAPI.LoadSprite("sprites/blazenova/4.png");
                        childSprite3.sortingLayerName = "Top";
                        var headLimbBehaviour3 = deel3.GetComponent<LimbBehaviour>();
                        eyeBehaviour3.Limb = headLimbBehaviour3;
                        eyeBehaviour3.Renderer = childSprite3;
                        eyeBehaviour3.LargeRange = new Vector2(0.01f, 0.01f);
                        eyeBehaviour3.SmallRange = new Vector2(5.01f, 5.01f);

                        var eyeBehaviour4 = childObject.AddComponent<GorseEyeBehaviour>();
                        var deel4 = Instance.GetComponent<PersonBehaviour>().Limbs[3].transform; //lowerbody
                        var childObject4 = new GameObject("Helmet");
                        childObject4.transform.SetParent(deel4);
                        childObject4.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject4.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject4.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite4 = childObject4.AddComponent<SpriteRenderer>();
                        childSprite4.material = ModAPI.FindMaterial("VeryBright");
                        childSprite4.sprite = ModAPI.LoadSprite("sprites/blazenova/6.png");
                        childSprite4.sortingLayerName = "Top";
                        var headLimbBehaviour4 = deel4.GetComponent<LimbBehaviour>();
                        eyeBehaviour4.Limb = headLimbBehaviour4;
                        eyeBehaviour4.Renderer = childSprite4;
                        eyeBehaviour4.LargeRange = new Vector2(0.01f, 0.01f);
                        eyeBehaviour4.SmallRange = new Vector2(5.01f, 5.01f);

                        var eyeBehaviour5 = childObject.AddComponent<GorseEyeBehaviour>();
                        var deel5 = Instance.GetComponent<PersonBehaviour>().Limbs[4].transform; //upperleg front
                        var childObject5 = new GameObject("Helmet");
                        childObject5.transform.SetParent(deel5);
                        childObject5.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject5.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject5.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite5 = childObject5.AddComponent<SpriteRenderer>();
                        childSprite5.material = ModAPI.FindMaterial("VeryBright");
                        childSprite5.sprite = ModAPI.LoadSprite("sprites/blazenova/7.png");
                        childSprite5.sortingLayerName = "Top";
                        var headLimbBehaviour5 = deel5.GetComponent<LimbBehaviour>();
                        eyeBehaviour5.Limb = headLimbBehaviour5;
                        eyeBehaviour5.Renderer = childSprite5;
                        eyeBehaviour5.LargeRange = new Vector2(0.01f, 0.01f);
                        eyeBehaviour5.SmallRange = new Vector2(5.01f, 5.01f);

                        var eyeBehaviour6 = childObject.AddComponent<GorseEyeBehaviour>();
                        var deel6 = Instance.GetComponent<PersonBehaviour>().Limbs[5].transform; //lowerleg front
                        var childObject6 = new GameObject("Helmet");
                        childObject6.transform.SetParent(deel6);
                        childObject6.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject6.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject6.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite6 = childObject6.AddComponent<SpriteRenderer>();
                        childSprite6.material = ModAPI.FindMaterial("VeryBright");
                        childSprite6.sprite = ModAPI.LoadSprite("sprites/blazenova/8.png");
                        childSprite6.sortingLayerName = "Top";
                        var headLimbBehaviour6 = deel6.GetComponent<LimbBehaviour>();
                        eyeBehaviour6.Limb = headLimbBehaviour6;
                        eyeBehaviour6.Renderer = childSprite6;
                        eyeBehaviour6.LargeRange = new Vector2(0.01f, 0.01f);
                        eyeBehaviour6.SmallRange = new Vector2(5.01f, 5.01f);

                        var eyeBehaviour7 = childObject.AddComponent<GorseEyeBehaviour>();
                        var deel7 = Instance.GetComponent<PersonBehaviour>().Limbs[6].transform; //foot front
                        var childObject7 = new GameObject("Helmet");
                        childObject7.transform.SetParent(deel7);
                        childObject7.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject7.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject7.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite7 = childObject7.AddComponent<SpriteRenderer>();
                        childSprite7.material = ModAPI.FindMaterial("VeryBright");
                        childSprite7.sprite = ModAPI.LoadSprite("sprites/blazenova/9.png");
                        childSprite7.sortingLayerName = "Top";
                        var headLimbBehaviour7 = deel7.GetComponent<LimbBehaviour>();
                        eyeBehaviour7.Limb = headLimbBehaviour7;
                        eyeBehaviour7.Renderer = childSprite7;
                        eyeBehaviour7.LargeRange = new Vector2(0.01f, 0.01f);
                        eyeBehaviour7.SmallRange = new Vector2(5.01f, 5.01f);

                        var eyeBehaviour8 = childObject.AddComponent<GorseEyeBehaviour>();
                        var deel8 = Instance.GetComponent<PersonBehaviour>().Limbs[7].transform; //upperleg
                        var childObject8 = new GameObject("Helmet");
                        childObject8.transform.SetParent(deel8);
                        childObject8.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject8.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject8.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite8 = childObject8.AddComponent<SpriteRenderer>();
                        childSprite8.material = ModAPI.FindMaterial("VeryBright");
                        childSprite8.sprite = ModAPI.LoadSprite("sprites/blazenova/7.png");
                        childSprite8.sortingLayerName = "Back";
                        var headLimbBehaviour8 = deel8.GetComponent<LimbBehaviour>();
                        eyeBehaviour8.Limb = headLimbBehaviour8;
                        eyeBehaviour8.Renderer = childSprite8;
                        eyeBehaviour8.LargeRange = new Vector2(0.01f, 0.01f);
                        eyeBehaviour8.SmallRange = new Vector2(5.01f, 5.01f);

                        var eyeBehaviour9 = childObject.AddComponent<GorseEyeBehaviour>();
                        var deel9 = Instance.GetComponent<PersonBehaviour>().Limbs[8].transform; //lowerleg
                        var childObject9 = new GameObject("Helmet");
                        childObject9.transform.SetParent(deel9);
                        childObject9.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject9.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject9.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite9 = childObject9.AddComponent<SpriteRenderer>();
                        childSprite9.material = ModAPI.FindMaterial("VeryBright");
                        childSprite9.sprite = ModAPI.LoadSprite("sprites/blazenova/8.png");
                        childSprite9.sortingLayerName = "Back";
                        var headLimbBehaviour9 = deel9.GetComponent<LimbBehaviour>();
                        eyeBehaviour9.Limb = headLimbBehaviour9;
                        eyeBehaviour9.Renderer = childSprite9;
                        eyeBehaviour9.LargeRange = new Vector2(0.01f, 0.01f);
                        eyeBehaviour9.SmallRange = new Vector2(5.01f, 5.01f);

                        var eyeBehaviour10 = childObject.AddComponent<GorseEyeBehaviour>();
                        var deel10 = Instance.GetComponent<PersonBehaviour>().Limbs[9].transform; //foot
                        var childObject10 = new GameObject("Helmet");
                        childObject10.transform.SetParent(deel10);
                        childObject10.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject10.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject10.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite10 = childObject10.AddComponent<SpriteRenderer>();
                        childSprite10.material = ModAPI.FindMaterial("VeryBright");
                        childSprite10.sprite = ModAPI.LoadSprite("sprites/blazenova/9.png");
                        childSprite10.sortingLayerName = "Back";
                        var headLimbBehaviour10 = deel10.GetComponent<LimbBehaviour>();
                        eyeBehaviour10.Limb = headLimbBehaviour10;
                        eyeBehaviour10.Renderer = childSprite10;
                        eyeBehaviour10.LargeRange = new Vector2(0.01f, 0.01f);
                        eyeBehaviour10.SmallRange = new Vector2(5.01f, 5.01f);

                        var eyeBehaviour11 = childObject.AddComponent<GorseEyeBehaviour>();
                        var deel11 = Instance.GetComponent<PersonBehaviour>().Limbs[10].transform; //upperarm front
                        var childObject11 = new GameObject("Helmet");
                        childObject11.transform.SetParent(deel11);
                        childObject11.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject11.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject11.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite11 = childObject11.AddComponent<SpriteRenderer>();
                        childSprite11.material = ModAPI.FindMaterial("VeryBright");
                        childSprite11.sprite = ModAPI.LoadSprite("sprites/blazenova/3.png");
                        childSprite11.sortingLayerName = "Top";
                        var headLimbBehaviour11 = deel11.GetComponent<LimbBehaviour>();
                        eyeBehaviour11.Limb = headLimbBehaviour11;
                        eyeBehaviour11.Renderer = childSprite11;
                        eyeBehaviour11.LargeRange = new Vector2(0.01f, 0.01f);
                        eyeBehaviour11.SmallRange = new Vector2(5.01f, 5.01f);

                        var eyeBehaviour12 = childObject.AddComponent<GorseEyeBehaviour>();
                        var deel12 = Instance.GetComponent<PersonBehaviour>().Limbs[11].transform; //lowerarm front
                        var childObject12 = new GameObject("Helmet");
                        childObject12.transform.SetParent(deel12);
                        childObject12.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject12.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject12.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite12 = childObject12.AddComponent<SpriteRenderer>();
                        childSprite12.material = ModAPI.FindMaterial("VeryBright");
                        childSprite12.sprite = ModAPI.LoadSprite("sprites/blazenova/5.png");
                        childSprite12.sortingLayerName = "Top";
                        var headLimbBehaviour12 = deel12.GetComponent<LimbBehaviour>();
                        eyeBehaviour12.Limb = headLimbBehaviour12;
                        eyeBehaviour12.Renderer = childSprite12;
                        eyeBehaviour12.LargeRange = new Vector2(0.01f, 0.01f);
                        eyeBehaviour12.SmallRange = new Vector2(5.01f, 5.01f);

                        var eyeBehaviour13 = childObject.AddComponent<GorseEyeBehaviour>();
                        var deel13 = Instance.GetComponent<PersonBehaviour>().Limbs[12].transform; //upperarm
                        var childObject13 = new GameObject("Helmet");
                        childObject13.transform.SetParent(deel13);
                        childObject13.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject13.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject13.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite13 = childObject13.AddComponent<SpriteRenderer>();
                        childSprite13.material = ModAPI.FindMaterial("VeryBright");
                        childSprite13.sprite = ModAPI.LoadSprite("sprites/blazenova/3.png");
                        childSprite13.sortingLayerName = "Back";
                        var headLimbBehaviour13 = deel13.GetComponent<LimbBehaviour>();
                        eyeBehaviour13.Limb = headLimbBehaviour13;
                        eyeBehaviour13.Renderer = childSprite13;
                        eyeBehaviour13.LargeRange = new Vector2(0.01f, 0.01f);
                        eyeBehaviour13.SmallRange = new Vector2(5.01f, 5.01f);

                        var eyeBehaviour14 = childObject.AddComponent<GorseEyeBehaviour>();
                        var deel14 = Instance.GetComponent<PersonBehaviour>().Limbs[13].transform; //lowerarm
                        var childObject14 = new GameObject("Helmet");
                        childObject14.transform.SetParent(deel14);
                        childObject14.transform.localPosition = new Vector3(0f, 0f); // tweak these to edit the position of the hat
                        childObject14.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // rotate it
                        childObject14.transform.localScale = new Vector3(1f, 1f); // scale it
                        var childSprite14 = childObject14.AddComponent<SpriteRenderer>();
                        childSprite14.material = ModAPI.FindMaterial("VeryBright");
                        childSprite14.sprite = ModAPI.LoadSprite("sprites/blazenova/5.png");
                        childSprite14.sortingLayerName = "Back";
                        var headLimbBehaviour14 = deel14.GetComponent<LimbBehaviour>();
                        eyeBehaviour14.Limb = headLimbBehaviour14;
                        eyeBehaviour14.Renderer = childSprite14;
                        eyeBehaviour14.LargeRange = new Vector2(0.01f, 0.01f);
                        eyeBehaviour14.SmallRange = new Vector2(5.01f, 5.01f);

            foreach (var body in person.Limbs)
            {
                body.BaseStrength += 4f;
                body.Health *= 50f;
                body.InitialHealth *= 50f;
                body.ShotDamageMultiplier *= 0.4f;
                body.BreakingThreshold += 20f;
                body.BaseStrength += 6f;
                body.RegenerationSpeed += 40f;
                body.DiscomfortingHeatTemperature = 999999f;
                body.IsLethalToBreak = false;
                body.ImpactPainMultiplier *= 0.01f;
                body.Numbness *= 4.5f;
            }
        
            //get person


            //use the helper function to set each texture
            //parameters are as follows: 
            //  skin texture, flesh texture, bone texture, sprite scale
            //you can pass "null" to fall back to the original texture
            person.SetBodyTextures(skin, flesh, bone, 1);

            //change procedural damage colours if they interfere with your texture (rgb 0-255)
            person.SetBruiseColor(86, 62, 130); //main bruise colour. purple-ish by default
            person.SetSecondBruiseColor(154, 0, 7); //second bruise colour. red by default
            person.SetThirdBruiseColor(207, 206, 120); // third bruise colour. light yellow by default
            person.SetRottenColour(202, 199, 104); // rotten/zombie colour. light yellow/green by default
            person.SetBloodColour(108, 0, 4); // blood colour. dark red by default. note that this does not change decal nor particle effect colours. it only affects the procedural blood color which may or may not be rendered
        
                                                        DecalDescriptor DecalDescriptor1 = ScriptableObject.CreateInstance<DecalDescriptor>();
 
                        foreach (LimbBehaviour Limb in person.Limbs)
                        {
                            DecalDescriptor1.Sprites = Limb.BloodDecal.Sprites;
                            DecalDescriptor1.IgnoreRadius = Limb.BloodDecal.IgnoreRadius;
                            DecalDescriptor1.Color = new Color(NovaBloodSNS.RedColorValue, NovaBloodSNS.GreenColorValue, 
                            NovaBloodSNS.BlueColorValue, NovaBloodSNS.TransparencyValue);
                            Limb.BloodDecal = DecalDescriptor1;
                            Limb.BloodLiquidType = "Rpg Blood [SNS]";
                            Limb.CirculationBehaviour.Drain(Limb.CirculationBehaviour.Limits.y);
                            double num = (double)Limb.CirculationBehaviour.AddLiquid(Liquid.GetLiquid("Rpg Blood [SNS]"), Limb.CirculationBehaviour.Limits.y);
                        }
        
        }
    }
);

                        ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Blood Flask"),
                    NameOverride = "PowerCore [SNS]",
                    NameToOrderByOverride = "The Differences",
                    DescriptionOverride = "Charges people with magic (not really)",
                    CategoryOverride = ModAPI.FindCategory("The Differences"), 
                    ThumbnailOverride = ModAPI.LoadSprite("sprites/core.png"),
                    AfterSpawn = (Instance) => 
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("sprites/core.png");
                                                Instance.FixColliders();
                        Instance.GetComponent<PhysicalBehaviour>().ReflectsLasers = true;
                        Instance.GetComponent<PhysicalBehaviour>().TrueInitialMass *= 50f;
                        Instance.GetComponent<FlaskBehaviour>().LiquidContainer.transform.localScale = Vector3.zero;
                        Instance.GetComponent<FlaskBehaviour>().StartLiquid = new BloodContainer.SerialisableDistribution
                        {
                            LiquidID = manasns.ID,
                            Amount = 2.8f //a flask can only hold 2.8 units of liquid (1 L)
                        };
                    }
                }
            );

                                    ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Sword"),
                    NameOverride = "Protector Sword [BHS]",
                    NameToOrderByOverride = "The Differences",
                    DescriptionOverride = "OG Gear 1 (Owner: Synth[etic B. Sare])", // Synthetic Blackhole Sare (WAIT ITS MADE SENSE HOLY CRAP AGAHGAGFDGESGR)
                    CategoryOverride = ModAPI.FindCategory("The Differences"), 
                    ThumbnailOverride = ModAPI.LoadSprite("sprites/view/SWORD.png"),
                    AfterSpawn = (Instance) => 
                    {
                        var sword = Instance.GetComponent<EnergySwordBehaviour>();
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("sprites/Og sword.png");
                                                Instance.FixColliders();
                        Instance.GetComponent<PhysicalBehaviour>().ReflectsLasers = true;
                        Instance.GetComponent<PhysicalBehaviour>().TrueInitialMass *= 20f;
                        sword.Damage = 200000f;

                        
        //add a UseEventTrigger and set its action
        Instance.AddComponent<UseEventTrigger>().Action = () => {
          //spawn an effect by the name of "Spark" at the transform position
          ModAPI.CreateParticleEffect("Disintegration", Instance.transform.position);

          
        };
        
                    }
                }
            );

        /*                           ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Energy Sword"),
                    NameOverride = "God of Death's Sword [SNS]",
                    NameToOrderByOverride = "The Differences",
                    DescriptionOverride = "Charges people with magic (not really)",
                    CategoryOverride = ModAPI.FindCategory("The Differences"), 
                    ThumbnailOverride = ModAPI.LoadSprite("sprites/swordd.png"),
                    AfterSpawn = (Instance) => 
                    {
                                                Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("sprites/35712.png");
                        gameObject.AddComponent<EnergySwordBehaviour>().EnergySwordHilt.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("textures/35710.png");
                                                gameObject.AddComponent<EnergySwordBehaviour>().EnergySwordBlade.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("textures/35710.png");


          

                    }
                }
            );

*/

    
   

        }
    }
}


//gameObject.AddComponent<EnergySwordBehaviour>().BladeObject.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("textures/bowgun.png");

    public class golddiggerfst : Blood
    {
        public new const string ID = "Golden Blood [FST]";
        public new const float RedColorValue = 0.2f;
        public new const float GreenColorValue = 0.0f;
        public new const float BlueColorValue = 0f;
        public new const float TransparencyValue = 1.0f;
 
        public golddiggerfst() => this.Color = new Color(RedColorValue, GreenColorValue, BlueColorValue, TransparencyValue);
 
        public override void OnEnterContainer(BloodContainer container)
        {
 
        }
 
        public override void OnEnterLimb(LimbBehaviour limb)
        {
            if (limb.SpeciesIdentity == "Android")
            { 
                limb.Health = 0f;       
            }
            else if (limb.SpeciesIdentity == "Human")
            {
                if (limb.BloodLiquidType == "Golden Blood [FST]")
                    return;
                else
                {
                limb.Health = 0f;  
                }
            }
            else if (limb.SpeciesIdentity == "Gorse")
            {
                limb.Health = 0f;  
            }
        }
 
        public override void OnExitContainer(BloodContainer container)
        {
 
        }
    };

    public class sharphandBehaviour : MonoBehaviour
{
public void Awake()
{
var Voidcomponent = gameObject.GetComponent<PhysicalBehaviour>();
if (this.gameObject.GetComponent<LimbBehaviour>().IsAndroid == false)
{
var HumanPropertiesIg = ModAPI.FindPhysicalProperties("Human");
HumanPropertiesIg.Sharp = true;
HumanPropertiesIg.SharpAxes = new[]
{
new SharpAxis(Vector2.down, 0.0f, 0.4f, false, true),
};
Voidcomponent.Properties = HumanPropertiesIg;
}
else
{
var AndroidPropertiesIg = ModAPI.FindPhysicalProperties("AndroidArmour");
AndroidPropertiesIg.Sharp = true;
AndroidPropertiesIg.SharpAxes = new[]
{
new SharpAxis(Vector2.down, 0.0f, 0.4f, false, true),
};
Voidcomponent.Properties = AndroidPropertiesIg;
}
}
private void Lodged(Stabbing stabbing)
{
if (stabbing.victim.GetComponent<LimbBehaviour>() != null)
{
var voidlimb = stabbing.victim.GetComponent<LimbBehaviour>();
voidlimb.BreakingThreshold = -100000f;
voidlimb.transform.SendMessage("Break", SendMessageOptions.DontRequireReceiver);
}
}
private void OnDisable()
{
this.gameObject.SetActive(true);
GetComponent<sharphandBehaviour>().enabled = true;
}
};


 public class RandomHumanTextureBehaviour : MonoBehaviour
    {
        private void Start()
        {
            this.phys = gameObject.GetComponent<PhysicalBehaviour>();
            chosenIndex = UnityEngine.Random.Range(0, Textures.Count - 0); 
            NextTexture();   
            phys.ContextMenuOptions.Buttons.Add(menuButton = new ContextMenuButton("NextTexture", "Next texture", "Switches to the next texture", new UnityAction[1]
            {
                (UnityAction) (() =>
                {
                    NextTexture();
                    foreach (var limb in person.Limbs)
                    {
                        if (limb.GetComponent<RandomHumanTextureBehaviour>())
                        {
                            limb.GetComponent<RandomHumanTextureBehaviour>().chosenIndex = chosenIndex;
                        }
                    }
                })
            }));     
            phys.ContextMenuOptions.Buttons.Add(menuButton = new ContextMenuButton("PreviousTexture", "Previous texture", "Switches to the previous texture", new UnityAction[1]
            {
                (UnityAction) (() =>
                {
                    PreviousTexture();
                    foreach (var limb in person.Limbs)
                    {
                        if (limb.GetComponent<RandomHumanTextureBehaviour>())
                        {
                            limb.GetComponent<RandomHumanTextureBehaviour>().chosenIndex = chosenIndex;
                        }
                    }
                })
            }));
        }
        private void NextTexture()
        {
            chosenIndex += 1;
            if (chosenIndex > Textures.Count - 1)
            {
                chosenIndex = 0;
            }
            person.SetBodyTextures(Textures[chosenIndex]);
        }
        private void PreviousTexture()
        {
            chosenIndex -= 1;
            if (chosenIndex < 0)
            {
                chosenIndex = Textures.Count - 1;
            }
            person.SetBodyTextures(Textures[chosenIndex]);
        }

       public List<Texture2D> Textures = new List<Texture2D>();
       public int chosenIndex = -1;
       public PersonBehaviour person;
       private PhysicalBehaviour phys;
       private ContextMenuButton menuButton;
    }

