// SPDX-License-Identifier: UNLICENSED
pragma solidity ^0.8.19;

import "@openzeppelin/contracts/token/ERC1155/ERC1155.sol";
import "@openzeppelin/contracts/access/AccessControl.sol";

contract NftContract is ERC1155, AccessControl {
    address admin;
    bytes32 public constant ADMIN = keccak256("ADMIN_ROLE");
    uint NFT_AMOUNT = 1;

    constructor() ERC1155("https://dvtnft/by/{id}.json") {
        admin = msg.sender;
        _grantRole(DEFAULT_ADMIN_ROLE, msg.sender);
        _grantRole(ADMIN, msg.sender);
    }

    function mintNFT(uint[] memory ids) public {
        require(hasRole(ADMIN, msg.sender), "Caller is not admin");
        uint[] memory nftAmounts = new uint[](ids.length);
        for (uint i = 0; i <= ids.length - 1; i++)
            nftAmounts[i] = NFT_AMOUNT;
        _mintBatch(admin, ids, nftAmounts, "");
    }

    // id of NFT to exchange for funds
    // the winning bid amount of funds to exchange for NFT
    // address of funds (donation) recipient
    // address of NFT (winning bidder) recipient
    function exchangeFundsForNFT(address winner, uint nftId
    // , address fundsRecipient, uint amount
    ) public  { // onlyOwner
        _safeTransferFrom(msg.sender, winner, nftId, NFT_AMOUNT, "winner?");
        // sendFundsFrom(winner, fundsRecipient, amount);
    }

    // for testing purposes
    function getNFTBalanceByAddressAndID() public view returns (uint) {}
    
    function supportsInterface(bytes4 interfaceId) public view override(ERC1155, AccessControl) returns (bool) {
        return super.supportsInterface(interfaceId);
    }
}