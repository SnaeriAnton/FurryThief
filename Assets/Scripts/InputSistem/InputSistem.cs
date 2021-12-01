// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputSistem/InputSistem.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputSistem : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSistem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSistem"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""17f0a1dd-fd3e-4d9a-a03f-591ab252a213"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""4e185188-c1b3-453f-95d1-9a7a4fcf7f0e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveOnLadder"",
                    ""type"": ""Value"",
                    ""id"": ""d1177557-a6a2-4913-8786-1c7f31d27fc9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""ad047327-dcb1-4e17-bd16-130decb1a620"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Descent"",
                    ""type"": ""Button"",
                    ""id"": ""1707e023-30b4-4b1e-8254-622bbdf36d65"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Hide"",
                    ""type"": ""Button"",
                    ""id"": ""8ae5d4f2-1fc5-4828-9c57-221f30457fc0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Open"",
                    ""type"": ""Button"",
                    ""id"": ""886fa801-1b3e-4130-9495-566d5bd7fe0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AddItem"",
                    ""type"": ""Button"",
                    ""id"": ""a8af0fb8-b4ae-40b4-977c-1ee96ca3e8f5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Climb Ladder"",
                    ""type"": ""Button"",
                    ""id"": ""6700cf72-05c0-4faf-87d8-db7f92ee6b08"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sell"",
                    ""type"": ""Button"",
                    ""id"": ""fa0b20fe-f187-40d8-8829-70b9a88049f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BreakingDoor"",
                    ""type"": ""Button"",
                    ""id"": ""324e70c0-253f-4153-b9df-c6ca01838043"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CutWires"",
                    ""type"": ""Button"",
                    ""id"": ""5c1f944a-278d-4450-a880-74904188b28c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""92514465-3a67-4384-ade9-07c43086fc45"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""21e991a3-611e-4873-983e-fc3f7e968dd9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""b193ae87-216a-49c8-aaa9-bcf915849142"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""f3277ee2-6f57-4357-a72d-9bb31bcfb8c0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveOnLadder"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9c173064-f238-4ce5-b9da-20f3fd204ff8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveOnLadder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""19408e6c-f382-4173-9de8-c487902e4864"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveOnLadder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8966189b-6519-417e-a9da-6cdb77b38687"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d6c749a-c25d-4645-94dd-13f9cd3edccc"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Descent"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""348067d7-7229-45bd-b578-b49d749a325e"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Hide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""989c4ae6-1976-44f5-9b30-b82b64500d1e"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Open"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1848059e-b9ad-4d1b-9be6-40a41121c953"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""AddItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""635a93e6-0850-4efe-9e15-9aa9d406bcfc"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Climb Ladder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c508538-8941-49a5-b410-8dfe5f10d00d"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Sell"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8cdf22e-be77-42f3-aef2-0e6496f88cdc"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BreakingDoor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7cc2a179-d3ec-4711-9e5a-cb760e692f66"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""CutWires"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""febdb0cc-a24e-424e-b91f-a4aa44c3e2f1"",
            ""actions"": [
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""6c6bdee5-80d1-47e9-883e-43f6dea29215"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d508eaf0-fee8-414d-bbb1-e8c3f42c47a4"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Tool"",
            ""id"": ""664e02c5-fe1a-4845-9f84-c9c8b8fd775d"",
            ""actions"": [
                {
                    ""name"": ""ChoiсeUp"",
                    ""type"": ""Button"",
                    ""id"": ""2b2db287-47bf-4928-b95c-98eaa14ed6b9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChoiсeDown"",
                    ""type"": ""Button"",
                    ""id"": ""a3f58cb2-9309-4be1-8dda-b824d01a8105"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c4f36e04-ee21-49c0-9d64-a11314eedb7d"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ChoiсeUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4592542a-edbe-46a3-9e0e-3426fc0273b8"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ChoiсeDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""TurnSrew"",
            ""id"": ""0c3664ca-fba3-4e65-b61b-322cd35440cc"",
            ""actions"": [
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""d7d967af-fd63-4227-bb47-8454c2791055"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""fcc5831e-25d2-4b4a-9d52-3697289b9d23"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Breaking"",
                    ""type"": ""Button"",
                    ""id"": ""f50d95e2-8bab-4847-932b-f00dd1e9c717"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""df69ad7f-e2ff-47d8-83e5-1e1bcaa38cdd"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""443f28d4-9016-443e-bc18-e351887150c2"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""abfa6245-2c23-4dc7-9b33-0bea5dc42961"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Breaking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Safe"",
            ""id"": ""e52e1798-8642-4db5-8659-61ab01106026"",
            ""actions"": [
                {
                    ""name"": ""Open"",
                    ""type"": ""Value"",
                    ""id"": ""e876c697-dc49-4f4b-a0c2-6347c5005a6f"",
                    ""expectedControlType"": ""Integer"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""efe1b8fb-ab30-4db5-aa88-573449b32a7c"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Open"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd3df7cd-d014-489f-94f8-dfe0adda4ffb"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Open"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce8b726a-854b-4cf5-932b-4a4d9804a292"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Open"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""baadbf93-d545-43d9-b731-8671575fe657"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Open"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a44b934-6c25-4c9f-a876-bdaf1d9ca545"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Open"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee074c34-f9b5-4673-acf6-6acd968a886b"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Open"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aeeac83c-2c7e-4d6e-a54a-9c49a444fea3"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Open"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ba1fa60-6f34-4661-a775-0f2218bbf0cb"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Open"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e70e1bdd-0c8a-4e2f-a1a8-3dcdbf1e8242"",
                    ""path"": ""<Keyboard>/9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Open"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""abbf328a-e22c-48d7-8b98-112b29acef4e"",
                    ""path"": ""<Keyboard>/0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Open"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Shop"",
            ""id"": ""4cd42c53-2721-468e-a4c5-ef9125a36836"",
            ""actions"": [
                {
                    ""name"": ""Open"",
                    ""type"": ""Button"",
                    ""id"": ""d12b585e-d54a-4264-96ae-b292d2cc7ed1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectLeft"",
                    ""type"": ""Button"",
                    ""id"": ""41da89b8-0457-4f9d-8709-7e9ab4db8d26"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectRight"",
                    ""type"": ""Button"",
                    ""id"": ""85b75f98-b5e6-49d2-8f9b-a12e21a98ebb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sell"",
                    ""type"": ""Button"",
                    ""id"": ""bc39daa5-a92f-49cb-b78a-cb66941abbd2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""958eca66-00ca-46c6-8c88-5b4021fe6444"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Open"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2bf24bd-d085-4080-85f6-cbb2accf2e4a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""SelectLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dbfc5efa-315d-4473-bb8d-315f8e3be599"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""SelectRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cecd2ae6-9053-4541-b955-eb4c3d21e2b2"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Sell"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_MoveOnLadder = m_Player.FindAction("MoveOnLadder", throwIfNotFound: true);
        m_Player_Exit = m_Player.FindAction("Exit", throwIfNotFound: true);
        m_Player_Descent = m_Player.FindAction("Descent", throwIfNotFound: true);
        m_Player_Hide = m_Player.FindAction("Hide", throwIfNotFound: true);
        m_Player_Open = m_Player.FindAction("Open", throwIfNotFound: true);
        m_Player_AddItem = m_Player.FindAction("AddItem", throwIfNotFound: true);
        m_Player_ClimbLadder = m_Player.FindAction("Climb Ladder", throwIfNotFound: true);
        m_Player_Sell = m_Player.FindAction("Sell", throwIfNotFound: true);
        m_Player_BreakingDoor = m_Player.FindAction("BreakingDoor", throwIfNotFound: true);
        m_Player_CutWires = m_Player.FindAction("CutWires", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Menu = m_Menu.FindAction("Menu", throwIfNotFound: true);
        // Tool
        m_Tool = asset.FindActionMap("Tool", throwIfNotFound: true);
        m_Tool_ChoiсeUp = m_Tool.FindAction("ChoiсeUp", throwIfNotFound: true);
        m_Tool_ChoiсeDown = m_Tool.FindAction("ChoiсeDown", throwIfNotFound: true);
        // TurnSrew
        m_TurnSrew = asset.FindActionMap("TurnSrew", throwIfNotFound: true);
        m_TurnSrew_MoveRight = m_TurnSrew.FindAction("MoveRight", throwIfNotFound: true);
        m_TurnSrew_MoveLeft = m_TurnSrew.FindAction("MoveLeft", throwIfNotFound: true);
        m_TurnSrew_Breaking = m_TurnSrew.FindAction("Breaking", throwIfNotFound: true);
        // Safe
        m_Safe = asset.FindActionMap("Safe", throwIfNotFound: true);
        m_Safe_Open = m_Safe.FindAction("Open", throwIfNotFound: true);
        // Shop
        m_Shop = asset.FindActionMap("Shop", throwIfNotFound: true);
        m_Shop_Open = m_Shop.FindAction("Open", throwIfNotFound: true);
        m_Shop_SelectLeft = m_Shop.FindAction("SelectLeft", throwIfNotFound: true);
        m_Shop_SelectRight = m_Shop.FindAction("SelectRight", throwIfNotFound: true);
        m_Shop_Sell = m_Shop.FindAction("Sell", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_MoveOnLadder;
    private readonly InputAction m_Player_Exit;
    private readonly InputAction m_Player_Descent;
    private readonly InputAction m_Player_Hide;
    private readonly InputAction m_Player_Open;
    private readonly InputAction m_Player_AddItem;
    private readonly InputAction m_Player_ClimbLadder;
    private readonly InputAction m_Player_Sell;
    private readonly InputAction m_Player_BreakingDoor;
    private readonly InputAction m_Player_CutWires;
    public struct PlayerActions
    {
        private @InputSistem m_Wrapper;
        public PlayerActions(@InputSistem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @MoveOnLadder => m_Wrapper.m_Player_MoveOnLadder;
        public InputAction @Exit => m_Wrapper.m_Player_Exit;
        public InputAction @Descent => m_Wrapper.m_Player_Descent;
        public InputAction @Hide => m_Wrapper.m_Player_Hide;
        public InputAction @Open => m_Wrapper.m_Player_Open;
        public InputAction @AddItem => m_Wrapper.m_Player_AddItem;
        public InputAction @ClimbLadder => m_Wrapper.m_Player_ClimbLadder;
        public InputAction @Sell => m_Wrapper.m_Player_Sell;
        public InputAction @BreakingDoor => m_Wrapper.m_Player_BreakingDoor;
        public InputAction @CutWires => m_Wrapper.m_Player_CutWires;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @MoveOnLadder.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveOnLadder;
                @MoveOnLadder.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveOnLadder;
                @MoveOnLadder.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveOnLadder;
                @Exit.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnExit;
                @Exit.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnExit;
                @Exit.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnExit;
                @Descent.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDescent;
                @Descent.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDescent;
                @Descent.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDescent;
                @Hide.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHide;
                @Hide.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHide;
                @Hide.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHide;
                @Open.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnOpen;
                @Open.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnOpen;
                @Open.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnOpen;
                @AddItem.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAddItem;
                @AddItem.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAddItem;
                @AddItem.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAddItem;
                @ClimbLadder.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnClimbLadder;
                @ClimbLadder.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnClimbLadder;
                @ClimbLadder.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnClimbLadder;
                @Sell.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSell;
                @Sell.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSell;
                @Sell.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSell;
                @BreakingDoor.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBreakingDoor;
                @BreakingDoor.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBreakingDoor;
                @BreakingDoor.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBreakingDoor;
                @CutWires.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCutWires;
                @CutWires.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCutWires;
                @CutWires.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCutWires;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @MoveOnLadder.started += instance.OnMoveOnLadder;
                @MoveOnLadder.performed += instance.OnMoveOnLadder;
                @MoveOnLadder.canceled += instance.OnMoveOnLadder;
                @Exit.started += instance.OnExit;
                @Exit.performed += instance.OnExit;
                @Exit.canceled += instance.OnExit;
                @Descent.started += instance.OnDescent;
                @Descent.performed += instance.OnDescent;
                @Descent.canceled += instance.OnDescent;
                @Hide.started += instance.OnHide;
                @Hide.performed += instance.OnHide;
                @Hide.canceled += instance.OnHide;
                @Open.started += instance.OnOpen;
                @Open.performed += instance.OnOpen;
                @Open.canceled += instance.OnOpen;
                @AddItem.started += instance.OnAddItem;
                @AddItem.performed += instance.OnAddItem;
                @AddItem.canceled += instance.OnAddItem;
                @ClimbLadder.started += instance.OnClimbLadder;
                @ClimbLadder.performed += instance.OnClimbLadder;
                @ClimbLadder.canceled += instance.OnClimbLadder;
                @Sell.started += instance.OnSell;
                @Sell.performed += instance.OnSell;
                @Sell.canceled += instance.OnSell;
                @BreakingDoor.started += instance.OnBreakingDoor;
                @BreakingDoor.performed += instance.OnBreakingDoor;
                @BreakingDoor.canceled += instance.OnBreakingDoor;
                @CutWires.started += instance.OnCutWires;
                @CutWires.performed += instance.OnCutWires;
                @CutWires.canceled += instance.OnCutWires;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Menu;
    public struct MenuActions
    {
        private @InputSistem m_Wrapper;
        public MenuActions(@InputSistem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Menu => m_Wrapper.m_Menu_Menu;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Menu.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnMenu;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // Tool
    private readonly InputActionMap m_Tool;
    private IToolActions m_ToolActionsCallbackInterface;
    private readonly InputAction m_Tool_ChoiсeUp;
    private readonly InputAction m_Tool_ChoiсeDown;
    public struct ToolActions
    {
        private @InputSistem m_Wrapper;
        public ToolActions(@InputSistem wrapper) { m_Wrapper = wrapper; }
        public InputAction @ChoiсeUp => m_Wrapper.m_Tool_ChoiсeUp;
        public InputAction @ChoiсeDown => m_Wrapper.m_Tool_ChoiсeDown;
        public InputActionMap Get() { return m_Wrapper.m_Tool; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ToolActions set) { return set.Get(); }
        public void SetCallbacks(IToolActions instance)
        {
            if (m_Wrapper.m_ToolActionsCallbackInterface != null)
            {
                @ChoiсeUp.started -= m_Wrapper.m_ToolActionsCallbackInterface.OnChoiсeUp;
                @ChoiсeUp.performed -= m_Wrapper.m_ToolActionsCallbackInterface.OnChoiсeUp;
                @ChoiсeUp.canceled -= m_Wrapper.m_ToolActionsCallbackInterface.OnChoiсeUp;
                @ChoiсeDown.started -= m_Wrapper.m_ToolActionsCallbackInterface.OnChoiсeDown;
                @ChoiсeDown.performed -= m_Wrapper.m_ToolActionsCallbackInterface.OnChoiсeDown;
                @ChoiсeDown.canceled -= m_Wrapper.m_ToolActionsCallbackInterface.OnChoiсeDown;
            }
            m_Wrapper.m_ToolActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ChoiсeUp.started += instance.OnChoiсeUp;
                @ChoiсeUp.performed += instance.OnChoiсeUp;
                @ChoiсeUp.canceled += instance.OnChoiсeUp;
                @ChoiсeDown.started += instance.OnChoiсeDown;
                @ChoiсeDown.performed += instance.OnChoiсeDown;
                @ChoiсeDown.canceled += instance.OnChoiсeDown;
            }
        }
    }
    public ToolActions @Tool => new ToolActions(this);

    // TurnSrew
    private readonly InputActionMap m_TurnSrew;
    private ITurnSrewActions m_TurnSrewActionsCallbackInterface;
    private readonly InputAction m_TurnSrew_MoveRight;
    private readonly InputAction m_TurnSrew_MoveLeft;
    private readonly InputAction m_TurnSrew_Breaking;
    public struct TurnSrewActions
    {
        private @InputSistem m_Wrapper;
        public TurnSrewActions(@InputSistem wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveRight => m_Wrapper.m_TurnSrew_MoveRight;
        public InputAction @MoveLeft => m_Wrapper.m_TurnSrew_MoveLeft;
        public InputAction @Breaking => m_Wrapper.m_TurnSrew_Breaking;
        public InputActionMap Get() { return m_Wrapper.m_TurnSrew; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TurnSrewActions set) { return set.Get(); }
        public void SetCallbacks(ITurnSrewActions instance)
        {
            if (m_Wrapper.m_TurnSrewActionsCallbackInterface != null)
            {
                @MoveRight.started -= m_Wrapper.m_TurnSrewActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_TurnSrewActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_TurnSrewActionsCallbackInterface.OnMoveRight;
                @MoveLeft.started -= m_Wrapper.m_TurnSrewActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_TurnSrewActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_TurnSrewActionsCallbackInterface.OnMoveLeft;
                @Breaking.started -= m_Wrapper.m_TurnSrewActionsCallbackInterface.OnBreaking;
                @Breaking.performed -= m_Wrapper.m_TurnSrewActionsCallbackInterface.OnBreaking;
                @Breaking.canceled -= m_Wrapper.m_TurnSrewActionsCallbackInterface.OnBreaking;
            }
            m_Wrapper.m_TurnSrewActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @Breaking.started += instance.OnBreaking;
                @Breaking.performed += instance.OnBreaking;
                @Breaking.canceled += instance.OnBreaking;
            }
        }
    }
    public TurnSrewActions @TurnSrew => new TurnSrewActions(this);

    // Safe
    private readonly InputActionMap m_Safe;
    private ISafeActions m_SafeActionsCallbackInterface;
    private readonly InputAction m_Safe_Open;
    public struct SafeActions
    {
        private @InputSistem m_Wrapper;
        public SafeActions(@InputSistem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Open => m_Wrapper.m_Safe_Open;
        public InputActionMap Get() { return m_Wrapper.m_Safe; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SafeActions set) { return set.Get(); }
        public void SetCallbacks(ISafeActions instance)
        {
            if (m_Wrapper.m_SafeActionsCallbackInterface != null)
            {
                @Open.started -= m_Wrapper.m_SafeActionsCallbackInterface.OnOpen;
                @Open.performed -= m_Wrapper.m_SafeActionsCallbackInterface.OnOpen;
                @Open.canceled -= m_Wrapper.m_SafeActionsCallbackInterface.OnOpen;
            }
            m_Wrapper.m_SafeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Open.started += instance.OnOpen;
                @Open.performed += instance.OnOpen;
                @Open.canceled += instance.OnOpen;
            }
        }
    }
    public SafeActions @Safe => new SafeActions(this);

    // Shop
    private readonly InputActionMap m_Shop;
    private IShopActions m_ShopActionsCallbackInterface;
    private readonly InputAction m_Shop_Open;
    private readonly InputAction m_Shop_SelectLeft;
    private readonly InputAction m_Shop_SelectRight;
    private readonly InputAction m_Shop_Sell;
    public struct ShopActions
    {
        private @InputSistem m_Wrapper;
        public ShopActions(@InputSistem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Open => m_Wrapper.m_Shop_Open;
        public InputAction @SelectLeft => m_Wrapper.m_Shop_SelectLeft;
        public InputAction @SelectRight => m_Wrapper.m_Shop_SelectRight;
        public InputAction @Sell => m_Wrapper.m_Shop_Sell;
        public InputActionMap Get() { return m_Wrapper.m_Shop; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShopActions set) { return set.Get(); }
        public void SetCallbacks(IShopActions instance)
        {
            if (m_Wrapper.m_ShopActionsCallbackInterface != null)
            {
                @Open.started -= m_Wrapper.m_ShopActionsCallbackInterface.OnOpen;
                @Open.performed -= m_Wrapper.m_ShopActionsCallbackInterface.OnOpen;
                @Open.canceled -= m_Wrapper.m_ShopActionsCallbackInterface.OnOpen;
                @SelectLeft.started -= m_Wrapper.m_ShopActionsCallbackInterface.OnSelectLeft;
                @SelectLeft.performed -= m_Wrapper.m_ShopActionsCallbackInterface.OnSelectLeft;
                @SelectLeft.canceled -= m_Wrapper.m_ShopActionsCallbackInterface.OnSelectLeft;
                @SelectRight.started -= m_Wrapper.m_ShopActionsCallbackInterface.OnSelectRight;
                @SelectRight.performed -= m_Wrapper.m_ShopActionsCallbackInterface.OnSelectRight;
                @SelectRight.canceled -= m_Wrapper.m_ShopActionsCallbackInterface.OnSelectRight;
                @Sell.started -= m_Wrapper.m_ShopActionsCallbackInterface.OnSell;
                @Sell.performed -= m_Wrapper.m_ShopActionsCallbackInterface.OnSell;
                @Sell.canceled -= m_Wrapper.m_ShopActionsCallbackInterface.OnSell;
            }
            m_Wrapper.m_ShopActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Open.started += instance.OnOpen;
                @Open.performed += instance.OnOpen;
                @Open.canceled += instance.OnOpen;
                @SelectLeft.started += instance.OnSelectLeft;
                @SelectLeft.performed += instance.OnSelectLeft;
                @SelectLeft.canceled += instance.OnSelectLeft;
                @SelectRight.started += instance.OnSelectRight;
                @SelectRight.performed += instance.OnSelectRight;
                @SelectRight.canceled += instance.OnSelectRight;
                @Sell.started += instance.OnSell;
                @Sell.performed += instance.OnSell;
                @Sell.canceled += instance.OnSell;
            }
        }
    }
    public ShopActions @Shop => new ShopActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMoveOnLadder(InputAction.CallbackContext context);
        void OnExit(InputAction.CallbackContext context);
        void OnDescent(InputAction.CallbackContext context);
        void OnHide(InputAction.CallbackContext context);
        void OnOpen(InputAction.CallbackContext context);
        void OnAddItem(InputAction.CallbackContext context);
        void OnClimbLadder(InputAction.CallbackContext context);
        void OnSell(InputAction.CallbackContext context);
        void OnBreakingDoor(InputAction.CallbackContext context);
        void OnCutWires(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnMenu(InputAction.CallbackContext context);
    }
    public interface IToolActions
    {
        void OnChoiсeUp(InputAction.CallbackContext context);
        void OnChoiсeDown(InputAction.CallbackContext context);
    }
    public interface ITurnSrewActions
    {
        void OnMoveRight(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnBreaking(InputAction.CallbackContext context);
    }
    public interface ISafeActions
    {
        void OnOpen(InputAction.CallbackContext context);
    }
    public interface IShopActions
    {
        void OnOpen(InputAction.CallbackContext context);
        void OnSelectLeft(InputAction.CallbackContext context);
        void OnSelectRight(InputAction.CallbackContext context);
        void OnSell(InputAction.CallbackContext context);
    }
}
