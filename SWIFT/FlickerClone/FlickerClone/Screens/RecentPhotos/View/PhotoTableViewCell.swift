//
//  PhotoTableViewCell.swift
//  FlickerClone
//
//  Created by Yunus Emre Kaya on 16.07.2022.
//

import UIKit

class PhotoTableViewCell: UITableViewCell {

    @IBOutlet var userImageView: UIImageView!
    @IBOutlet var userLabel: UILabel!
    @IBOutlet var photoLabel: UILabel!
    
    @IBOutlet var photoImageView: UIImageView!
    
    override func awakeFromNib() {
        super.awakeFromNib()
        userImageView.layer.cornerRadius = 24
        
    }

    override func setSelected(_ selected: Bool, animated: Bool) {
        super.setSelected(selected, animated: animated)

        // Configure the view for the selected state
    }

}
