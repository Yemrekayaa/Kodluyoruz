//
//  PhotoDetailViewController.swift
//  FlickerClone
//
//  Created by Yunus Emre Kaya on 16.07.2022.
//

import UIKit

class PhotoDetailViewController: UIViewController {
    
    var photo: Photo?
    
    @IBOutlet var photoTextView: UITextView!
    @IBOutlet var userLabel: UILabel!
    @IBOutlet var userImageView: UIImageView!
    @IBOutlet var photoImageView: UIImageView!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        
        title = photo?.title
        
        photoTextView.text = photo?.photoDescription?.content
        userLabel.text = photo?.ownername
        userImageView.backgroundColor = .darkGray
        photoImageView.backgroundColor = .darkGray
        
        
        NetworkManager.shared.fetchImage(with: photo?.urlZ) { data in
            self.photoImageView.image = UIImage(data: data)
        }
        NetworkManager.shared.fetchImage(with: photo?.bodyIconURL) { data in
            self.userImageView.image = UIImage(data: data)
        }
        
    }
    
    
    
    
    
}
